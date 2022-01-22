using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celcius to Fahrenheit! (49)");
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(49.0));

            Console.WriteLine("Fahrenheit to Celcius! (49)");
            Console.WriteLine(TempConverter.FahrenheitToCelsius(49.0));
        }
    }
}
