using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace StreamsAndFileSystems.Classes
{
    class ForCsv
    {
        public static void AddDataToCsv(StreamWriter streamWriter, int data1, int data2)
        {
            streamWriter.Write(data1);
            streamWriter.Write(",");
            streamWriter.WriteLine(data2);
            streamWriter.Flush();
        }

        public static void ReadDataFromCsv(StreamReader streamReader, out int data1, out int data2)
        {
            var line = streamReader.ReadLine();
            var substring = line.Split(",");
            data1 = int.Parse(substring[0]);
            data2 = int.Parse(substring[1]);
        }

    }
}
