//5.Write a program in C# to display temperature in Celsius. Accept the temperature in Fahrenheit.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Temperature in Celsius : ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit : " + fahrenheit);

            Console.ReadLine();
        }
    }
}
