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
                // LÄGG IN INPUT FÖR ATT SLUMPA!
                Console.WriteLine("Implementing Rectangle with length 2 & width 4");
                Ellipse shape = new Ellipse(4);
                Console.WriteLine($"Length: {shape.Length}");
                Console.WriteLine($"Width: {shape.Width}");
                Console.WriteLine($"Area: {shape.Area}");
                Console.WriteLine($"Perimeter: {shape.Perimeter}");
                Console.WriteLine($"ToString(R): {shape.ToString("R")}");
                Console.WriteLine($"ToString(): {shape.ToString()}");
                Console.WriteLine($"ToString(empty): {shape.ToString("")}");
                Console.WriteLine($"ToString(null): {shape.ToString(null)}");
                Console.WriteLine($"is3D: {shape.Is3D}");
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