using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace cslt_chiều_t3.session_3
{
    internal class bt
    {
        public static void Main(string[] args)
        {
            double celsius = Convert.ToSByte(Console.ReadLine());
            double kelvin = celsius + 273;
            double fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine($"kelvin= {kelvin}");
            Console.WriteLine($"fahrenheit= {fahrenheit}");
        }

    }
}
