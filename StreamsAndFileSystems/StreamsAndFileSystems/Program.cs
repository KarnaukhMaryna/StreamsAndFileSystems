using StreamsAndFileSystems.Classes;
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;

namespace StreamsAndFileSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "output_" + DateTime.Today.ToString("yyyy_MM_dd", CultureInfo.InvariantCulture);
            StreamWriter streamWriterTxt = new StreamWriter($"D:\\Project\\{filename}.txt");
            StreamWriter streamWriterCsv = new StreamWriter($"D:\\Project\\{filename}.csv");
            int data1, data2;

            Console.WriteLine("Please, select input file extension. If you want to choose .txt press 1, if .csv press 2");
            int inputExtension = int.Parse(Console.ReadLine());
            switch (inputExtension)
            {
                case 1:                  
                    ForTxt.AddDataToTxt(streamWriterTxt, 10, 5);
                    streamWriterTxt.Close();
                    StreamReader streamReaderTxt = new StreamReader($"D:\\Project\\{filename}.txt");
                    ForTxt.ReadDataFromTxt(streamReaderTxt, out data1, out data2);
                    OperationsWithData.SumOfNumbers(streamWriterCsv, data1, data2);
                    OperationsWithData.MultiplyOfNumbers(streamWriterCsv, data1, data2);
                    OperationsWithData.DivideOfNumbers(streamWriterCsv, data1, data2);
                    streamWriterCsv.Close();
                    break;
                case 2:
                    ForCsv.AddDataToCsv(streamWriterCsv, 15, 16);
                    streamWriterCsv.Close();
                    StreamReader streamReaderCsv = new StreamReader($"D:\\Project\\{filename}.csv");
                    ForCsv.ReadDataFromCsv(streamReaderCsv, out data1, out data2);
                    OperationsWithData.SumOfNumbers(streamWriterTxt, data1, data2);
                    OperationsWithData.MultiplyOfNumbers(streamWriterTxt, data1, data2);
                    OperationsWithData.DivideOfNumbers(streamWriterTxt, data1, data2);
                    streamWriterTxt.Close();
                    break;

            }
 
        }
    }
}
