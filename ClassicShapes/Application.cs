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
                Rectangle rect = new Rectangle(2, 4);
                Console.WriteLine($"Length: {rect.Length}");
                Console.WriteLine($"Width: {rect.Width}");
                Console.WriteLine($"Area: {rect.Area}");
                Console.WriteLine($"Perimeter: {rect.Perimeter}");
                Console.WriteLine($"ToString(R): {rect.ToString("R")}");
                Console.WriteLine($"ToString(): {rect.ToString()}");
                Console.WriteLine($"ToString(empty): {rect.ToString("")}");
                Console.WriteLine($"ToString(null): {rect.ToString(null)}");
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