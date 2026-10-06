using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число (double): ");
            double val = double.Parse(Console.ReadLine());

            float f = (float)val;
            long l = (long)f;
            int i = (int)l;
            short s = (short)i;
            byte b = (byte)s;

            Console.WriteLine($"double: {val}");
            Console.WriteLine($"float: {f}");
            Console.WriteLine($"long: {l}");
            Console.WriteLine($"int: {i}");
            Console.WriteLine($"short: {s}");
            Console.WriteLine($"byte: {b}");
        }
    }
}