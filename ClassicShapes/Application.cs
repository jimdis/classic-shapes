using System;

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
                    input = Console.ReadLine();
                } while (input != "3D" && input != "2D");

                bool get3D = input == "3D";

                int numberOfFigures;
                do
                {
                    Console.Write("How many shapes should be generated? [1 - 100]: ");
                } while (!(int.TryParse(Console.ReadLine(), out numberOfFigures) &&
                         numberOfFigures >= 1 &&
                         numberOfFigures <= 100));

                Shape[] shapes = new Shape[numberOfFigures];

                Random random = new Random();
                Array shapeTypes = Enum.GetValues(typeof(ShapeType));

                for (int i = 0; i < numberOfFigures; i++)
                {
                    double[] measurements = new double[3];
                    for (int j = 0; j < measurements.Length; j++)
                    {
                        measurements[j] = random.NextDouble() * 100 + 0.1;
                    }

                    Shape shape;
                    do
                    {
                        ShapeType shapetype = (ShapeType)shapeTypes.GetValue(random.Next(shapeTypes.Length));
                        shape = GetRandomShape(shapetype, measurements);
                    } while (shape.Is3D != get3D);

                    shapes[i] = shape;

                }

                OutputShapes(shapes);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"ERROR: {ex}");
            }

        }

        private static Shape GetRandomShape(ShapeType shapetype, double[] measurements)
        {
            double w = measurements[0];
            double l = measurements[1];
            double h = measurements[2];

            switch (shapetype)
            {
                case ShapeType.Rectangle: return new Rectangle(w, l);
                case ShapeType.Ellipse: return new Ellipse(w, l);
                case ShapeType.Cylinder: return new Cylinder(w, l, h);
                case ShapeType.Cuboid: return new Cuboid(w, l, h);
                case ShapeType.Sphere: return new Sphere(w);
                default: return null;
            }
        }

        /// <summary>
        /// Prints out a table of descriptive statistics to the console.
        /// </summary>
        /// <param name="statistics">The dynamic object containing the descriptive statistics</param>
        private static void OutputShapes(Shape[] shapes)
        {
            string format;
            do
            {
                Console.Write("Type R to display shapes in rows. Type G or display shapes individually: ");
                format = Console.ReadLine();
            } while (format != "R" && format != "G");

            if (format == "R")
            {
                string[] headers = { "Length", "Width", "Perimeter", "Area" };
                int padding = 15;
                string align = "{0," + padding + ":f1}";
                string headerRow = $"{"Shape".PadRight(padding)}";

                for (int i = 0; i < headers.Length; i++)
                {
                    headerRow += String.Format(align, headers[i]);
                }
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine(headerRow);
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString(format));
            }
            if (format == "R") Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}