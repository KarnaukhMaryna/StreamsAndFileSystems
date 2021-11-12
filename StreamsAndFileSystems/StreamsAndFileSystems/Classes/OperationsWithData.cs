using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StreamsAndFileSystems.Classes
{
    class OperationsWithData
    {
        public static void SumOfNumbers(StreamWriter streamWriter, int data1, int data2) => streamWriter.Write($"{data1 += data2}" + ",");

        public static void MultiplyOfNumbers(StreamWriter streamWriter, int data1, int data2) => streamWriter.Write($"{data1 *= data2}" + ",");

        public static void DivideOfNumbers(StreamWriter streamWriter, int data1, int data2)
        {
            if (data2 != 0)
            {
                streamWriter.Write($"{data1 /= data2}" + ",");
            }
        }
    }
}
