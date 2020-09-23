using System;

namespace UserDefinedMethods
{
    class Program
    {
        // access modifier (public/private) - static modifier (either static or blank)
        // return type (data type to expect back from method)
        // name - make sure it's clear what it does
        // parameter list - can be zero or more, data type then parameter name seperated by commas
        public static float CelsiusToFahrenheit(float celsius)
        {
            float fahrenheit = 0.0f;

            fahrenheit = (celsius * (9.0f / 5.0f)) + 32;
            return fahrenheit;
        }

        public static float FahrenheitToCelsius(float fahrenheit)
        {
            float celsius = 0.0f;
            celsius = (fahrenheit - 32) * (5.0f/9.0f) ;

            return celsius;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter c to convert to celsius, f to convert to fahrenheit: ");
            String converttype = Console.ReadLine();

            Console.Write("Enter value to convert: ");
            String userTemp = Console.ReadLine();
            float temp = float.Parse(userTemp);

            if (converttype == "c")
            {
                Console.WriteLine(temp + "F = " + FahrenheitToCelsius(temp) + "C" );
            } else
            {
                Console.WriteLine(temp + "C = " + CelsiusToFahrenheit(temp) + "F");
            }
            
        }
    }
}
