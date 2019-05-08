using System;
using System.Linq;

namespace ClassicShapes
{
    /// <summary>
    /// Represents a console application.
    /// </summary>
    public static class Application
    {
        /// <summary>
        /// Runs an application.
        /// </summary>
        public static void Run()
        {
            try
            {
                string input;
                do
                {
                    Console.Write("Choose your shape (\"2D\" or \"3D\"): ");
                    input = Console.ReadLine().ToUpper();
                } while (input != "3D" && input != "2D");

                bool get3D = input == "3D";

                int numberOfShapes;
                do
                {
                    Console.Write("How many shapes should be generated? [1 - 100]: ");
                } while (!(int.TryParse(Console.ReadLine(), out numberOfShapes) &&
                        numberOfShapes >= 1 &&
                        numberOfShapes <= 100));

                Shape[] shapes = GetShapes(get3D, numberOfShapes);

                OutputShapes(shapes);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"ERROR: {ex}");
            }

        }

        /// <summary>
        /// Returns an Array of sorted Shapes based on argument list.
        /// </summary>
        /// <param name="get3D">True if the returned Shapes should be 3D shapes.</param>
        /// <param name="numberOfShapes">Number of Shapes to include in the returned Array.</param>
        /// <returns>An Array of sorted Shapes.</returns>
        private static Shape[] GetShapes(bool get3D, int numberOfShapes)
        {
            Random random = new Random();
            ShapeType[] shapeTypes3D = { ShapeType.Cuboid, ShapeType.Cylinder, ShapeType.Sphere };
            ShapeType[] shapeTypes2D = { ShapeType.Ellipse, ShapeType.Rectangle };


            Shape2D[] shapes2D = new Shape2D[numberOfShapes];
            Shape3D[] shapes3D = new Shape3D[numberOfShapes];

            for (int i = 0; i < numberOfShapes; i++)
            {
                double w = random.NextDouble() * 100 + 0.1;
                double l = random.NextDouble() * 100 + 0.1;
                double h = random.NextDouble() * 100 + 0.1;

                Shape2D shape2D = null;
                Shape3D shape3D = null;

                if (get3D)
                {
                    ShapeType shapeType = shapeTypes3D[random.Next(shapeTypes3D.Length)];
                    switch (shapeType)
                    {
                        case ShapeType.Cylinder:
                            shape3D = new Cylinder(w, l, h);
                            break;
                        case ShapeType.Cuboid:
                            shape3D = new Cuboid(w, l, h);
                            break;
                        case ShapeType.Sphere:
                            shape3D = new Sphere(w);
                            break;
                    }
                    shapes3D[i] = shape3D;
                }
                else
                {
                    ShapeType shapeType = shapeTypes2D[random.Next(shapeTypes2D.Length)];
                    switch (shapeType)
                    {
                        case ShapeType.Rectangle:
                            shape2D = new Rectangle(w, l);
                            break;
                        case ShapeType.Ellipse:
                            shape2D = new Ellipse(w, l);
                            break;
                    }
                    shapes2D[i] = shape2D;
                }
            }

            Shape[] shapes = new Shape[numberOfShapes];

            if (get3D)
            {
                shapes = shapes3D
                    .OrderBy(shape => shape.ShapeType.ToString())
                    .ThenByDescending(shape => shape.Volume)
                    .ToArray();
            }
            else
            {
                shapes = shapes2D
                    .OrderBy(shape => shape.ShapeType.ToString())
                    .ThenByDescending(shape => shape.Area)
                    .ToArray(); ;
            }

            return shapes;
        }

        /// <summary>
        /// Prints out data about the Shapes to the console based on user input.
        /// </summary>
        /// <param name="shapes">An array of Shapes</param>
        private static void OutputShapes(Shape[] shapes)
        {
            string format;
            do
            {
                Console.Write("Type R to display shapes in rows. Type G or display shapes individually: ");
                format = Console.ReadLine().ToUpper();
            } while (format != "R" && format != "G");

            bool is3D = shapes[0].Is3D;
            string separator = is3D ? "--------------------------------------------------------------------------------------------" :
                "-----------------------------------------------------";

            if (format == "R")
            {
                string[] headers2D = { "Length", "Width", "Perimeter", "Area" };
                string[] headers3D = { "Length", "Width", "Height", "Mantel Area", "Total Surface Area", "Volume" };

                int length = shapes[0].Is3D ? headers3D.Length : headers2D.Length;

                string headerRow = $"{"Shape ".PadRight(9)}";
                for (int i = 0; i < length; i++)
                {
                    headerRow += String.Format("{0," + (is3D ? headers3D[i].Length + 5 : headers2D[i].Length + 5) + ":f1}", is3D ? headers3D[i] : headers2D[i]);
                }
                Console.WriteLine(separator);
                Console.WriteLine(headerRow);
                Console.WriteLine(separator);
            }
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString(format));
            }
            if (format == "R") Console.WriteLine(separator);
        }
    }
}