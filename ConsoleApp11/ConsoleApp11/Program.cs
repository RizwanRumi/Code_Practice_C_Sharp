using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;

namespace ConsoleApp11
{
    internal class Program
    {
        //static void Main()
        //{
        //    FileReader fileReader = new FileReader();
        //    SignalParser signalParser = new SignalParser();

        //    // Read lines from the input file
        //    List<string> lines = fileReader.ReadFile("E:\\C#_Projects\\testExample\\testExample\\InputFile.txt");


        //    // Parse signals from the lines
        //    Dictionary<int, int> signalValues = signalParser.ParseSignals(lines);

        //    // Display the values of "Signal 2_1" in specified rows
        //    Console.WriteLine($"Signal_2_1 value in Row 2 = {signalValues.GetValueOrDefault(2, 0)} (0x{signalValues.GetValueOrDefault(2, 0):X})");
        //    Console.WriteLine($"Signal_2_1 value in Row 12 = {signalValues.GetValueOrDefault(12, 0)} (0x{signalValues.GetValueOrDefault(12, 0):X})");
        //}


        private static SignalDecoder signalDecoder = null;
        static void Main(string[] args)
        {

            string path = @"E:\C#_Projects\ConsoleApp11\ConsoleApp11\Resources\InputFile.txt";

            var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fs, Encoding.UTF8);
            string data = String.Empty;
            List<string> lines = new List<string>();

            while ((data = sr.ReadLine()) != null)
            {
                lines.Add(data);
            }

                //signalDecoder = new SignalDecoder(@"Resources/InputFile.txt");

                string originalString = "02060505";

            List<string> values = new List<string>();

            string tmp = "";
            // Copy characters from the original string into the arrays
            for (int i = 0; i < originalString.Length; i++)
            {
                tmp += originalString[i];

                if((i%2 == 1))
                {
                    values.Add(tmp);
                    tmp = "";
                }
            }

           

            // Output the split strings
            foreach (string str in values)
            {
                Console.WriteLine(str);
            }


            //try
            //{
            //    string filePath = "E:\\C#_Projects\\testExample\\testExample\\InputFile.txt"; // Replace with the actual path to your input file.
            //    List<string> lines = File.ReadAllLines(filePath).ToList();

            //    int pduCount = 0;
            //    int signal2_1Count = 0;

            //    for (int i = 0; i < lines.Count; i++)
            //    {
            //        if (lines[i].Length < 2)
            //        {
            //            Console.WriteLine($"Invalid data on line {i + 1}: {lines[i]}");
            //            continue;
            //        }

            //        string pduId = lines[i].Substring(0, 2);
            //        if (pduId == "01")
            //        {
            //            pduCount++;
            //            signal2_1Count++;
            //            string signal2_1 = lines[i].Substring(4, 2);
            //            int signal2_1Decimal = Convert.ToInt32(signal2_1, 16);
            //            Console.WriteLine($"Signal_2_1 value in Row {i + 1} = {signal2_1Decimal} (0x{signal2_1})");
            //        }
            //        else if (pduId == "02")
            //        {
            //            int protocolCount = Convert.ToInt32(lines[i].Substring(2, 2), 16);
            //            for (int j = 0; j < protocolCount; j++)
            //            {
            //                string signalData = lines[i].Substring(4 + j * 2, 2);
            //                int signalDecimal = Convert.ToInt32(signalData, 16);
            //                Console.WriteLine($"Signal_2_{j + 1} value in Row {i + 1} = {signalDecimal} (0x{signalData})");
            //            }
            //        }
            //    }

            //    Console.WriteLine($"Total PDUs: {pduCount}");
            //    Console.WriteLine($"Total Signal_2_1 occurrences: {signal2_1Count}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");
            //}
        }
    }
}
