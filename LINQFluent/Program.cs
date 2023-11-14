using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace LINQFluent
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "test.txt";

            string[] text = File.ReadAllLines(filePath);

            int linesAbove30 = text.Where(line => line.Length > 30).Count();

            double averageNrOfChars = text.Select(line => line.Length).Average();

            bool anyLineAbove120 = text.Any(line => line.Length > 120);

            //string[] linesWithYUpper = text.Where(line => line.Contains("Y")).
            IEnumerable<string> linesWithYUpper =
                from line in text
                where line.Contains('Y')
                select line.Trim().Split(" ")[0].ToUpper();

            Console.WriteLine($"Lines above 30 char: {linesAbove30}");
            Console.WriteLine($"Average number of chars: {averageNrOfChars}");
            Console.WriteLine($"Any line above 120: {anyLineAbove120}");
            foreach (var line in linesWithYUpper)
            {
                Console.WriteLine(line);
            }
        }
    }
}
