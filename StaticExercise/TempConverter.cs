using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double input)
        {
            return (input - 32.0) * 5.0/9.0;
        }

        public static double CelsiusToFahrenheit(double input)
        {
            return (input * 9.0/5.0) + 32.0;
        }
    }
}
