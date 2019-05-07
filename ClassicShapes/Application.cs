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
                Console.WriteLine("Välj typ av figur (\"2D\"/\"3D\"");
                bool get3D = Console.ReadLine() == "3D";
                Console.WriteLine("Hur många figurer ska slumpas fram? (antal)");
                int numberOfFigures = int.Parse(Console.ReadLine());

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
            Console.WriteLine("Skriv R för att visa resultat i rader. Annars tryck enter");
            string format = Console.ReadLine();
            if (format != "R") format = null;

            if (format == "R")
            {
                string[] headers = { "Length", "Width", "Perimeter", "Area" };
                int padding = 15;
                string align = "{0," + padding + ":f1}";
                string output = $"{"Shape".PadRight(padding)}";

                for (int i = 0; i < headers.Length; i++)
                {
                    output += String.Format(align, headers[i]);
                }
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine(output);
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString(format));
            }
            Console.WriteLine("--------------------------------------------------------------------------------");

            //     var dict = new Dictionary<string, string>
            //         {
            //             ["Maximum"] = $"{statistics.Maximum}",
            //             ["Minimum"] = $"{statistics.Minimum}",
            //             ["Medelvärde"] = $"{statistics.Mean:f1}",
            //             ["Median"] = $"{statistics.Median}",
            //             ["Typvärde"] = $"{string.Join(", ", statistics.Mode)}",
            //             ["Variationsbredd"] = $"{statistics.Range}",
            //             ["Standardavvikelse"] = $"{statistics.StandardDeviation:f1}"

            //         };
            //     int padding = dict
            //         .Select(x => x.Key)
            //         .OrderByDescending(x => x.Length)
            //         .ToArray() [0].Length;

            //     // Console.WriteLine("\n----------------------");
            //     Console.WriteLine("\nDeskriptiv statistik");
            //     Console.WriteLine("-------------------------");
            //     foreach (KeyValuePair<string, string> kvp in dict)
            //     {
            //         Console.WriteLine($"{kvp.Key.PadRight(padding)}: {kvp.Value}");
            //     }
            //     Console.WriteLine("-------------------------\n");
            // }
        }
    }
}