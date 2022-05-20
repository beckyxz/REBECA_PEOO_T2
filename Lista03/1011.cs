using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1011
{
    class Program
    {
        static void Main(string[] args)
        {

            double R, raio;
            double pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            raio = (double) (4.0 / 3.0) * pi * Math.Pow(R,3.0);

            Console.WriteLine("VOLUME = " + raio.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}