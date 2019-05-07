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
                string figure = Console.ReadLine();
                Console.WriteLine("Hur många figurer ska slumpas fram? (antal)");
                int numberOfFigures = int.Parse(Console.ReadLine());

                Array values = Enum.GetValues(typeof(ShapeType));
                Random random = new Random();

                for (int i = 0; i < numberOfFigures; i++)
                {
                    ShapeType randomShape = (ShapeType)values.GetValue(random.Next(values.Length));
                    // int shapeNumber = random.Next(ShapeType.GetNames(typeof(ShapeType)).Length);
                    Console.WriteLine(randomShape);

                    // var shape = Activator.CreateInstance(Type.GetType(randomShape.ToString()));

                    // shape.
                    // Console.WriteLine(shapeNumber);
                    // Console.WriteLine((ShapeType)shapeNumber);

                }

                // LÄGG IN INPUT FÖR ATT SLUMPA!
                // Console.WriteLine("Implementing Rectangle with length 2 & width 4");
                // Rectangle shape2D = new Rectangle(2, 4);
                // Console.WriteLine($"Length: {shape2D.Length}");
                // Console.WriteLine($"Width: {shape2D.Width}");
                // Console.WriteLine($"Area: {shape2D.Area}");
                // Console.WriteLine($"Perimeter: {shape2D.Perimeter}");
                // Console.WriteLine($"ToString(R): {shape2D.ToString("R")}");
                // Console.WriteLine($"ToString(): {shape2D.ToString()}");
                // Console.WriteLine($"ToString(empty): {shape2D.ToString("")}");
                // Console.WriteLine($"ToString(null): {shape2D.ToString(null)}");
                // Console.WriteLine($"is3D: {shape2D.Is3D}");

                // Console.WriteLine("Implementing Sphere with Diameter 4");
                // Sphere shape3D = new Sphere(4);
                // Console.WriteLine($"Length: {shape3D.Length}");
                // Console.WriteLine($"Width: {shape3D.Width}");
                // Console.WriteLine($"Height: {shape3D.Height}");
                // Console.WriteLine($"Diameter: {shape3D.Diameter}");
                // Console.WriteLine($"MantelArea: {shape3D.MantelArea}");
                // Console.WriteLine($"TotalSurfaceArea: {shape3D.TotalSurfaceArea}");
                // Console.WriteLine($"Volume: {shape3D.Volume}");
                // Console.WriteLine($"ToString(R): {shape3D.ToString("R")}");
                // Console.WriteLine($"ToString(): {shape3D.ToString()}");
                // Console.WriteLine($"ToString(empty): {shape3D.ToString("")}");
                // Console.WriteLine($"ToString(null): {shape3D.ToString(null)}");
                // Console.WriteLine($"is3D: {shape3D.Is3D}");
                // Console.WriteLine("Changing Width to 6");
                // shape3D.Width = 6;
                // Console.WriteLine($"Length: {shape3D.Length}");
                // Console.WriteLine($"Width: {shape3D.Width}");
                // Console.WriteLine($"Height: {shape3D.Height}");
                // Console.WriteLine($"Diameter: {shape3D.Diameter}");
                // Console.WriteLine($"MantelArea: {shape3D.MantelArea}");
                // Console.WriteLine($"TotalSurfaceArea: {shape3D.TotalSurfaceArea}");
                // Console.WriteLine($"Volume: {shape3D.Volume}");
                // Console.WriteLine($"ToString(R): {shape3D.ToString("R")}");
                // Console.WriteLine($"ToString(): {shape3D.ToString()}");
                // Console.WriteLine($"ToString(empty): {shape3D.ToString("")}");
                // Console.WriteLine($"ToString(null): {shape3D.ToString(null)}");
                // Console.WriteLine($"is3D: {shape3D.Is3D}");

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"ERROR: {ex}");
            }

        }

        /// <summary>
        /// Prints out a table of descriptive statistics to the console.
        /// </summary>
        /// <param name="statistics">The dynamic object containing the descriptive statistics</param>
        // private static void ViewResult(dynamic statistics)
        // {
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