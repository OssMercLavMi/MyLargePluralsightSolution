using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        
    }

    class Temperature
    {
        static float FahreneitToCelsius(float temperatureFahreneit)
        {
            float temperatureCelsius = ((temperatureFahreneit - 32) / 1.8f);
            return temperatureCelsius;
        }
    }
}
