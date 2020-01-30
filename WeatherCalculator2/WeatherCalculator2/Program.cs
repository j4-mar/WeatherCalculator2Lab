using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int windSpeed;
            double windChill;
            string input = "";

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature");

            input = Console.ReadLine();

            temperature = int.Parse(input);

            //// Get the windspeed from the user
            //Console.WriteLine("Enter the wind speed");

            //input = Console.ReadLine();

            //windSpeed = int.Parse(input);

            //// Calculate the wind chill

            //windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

            //Console.WriteLine("The wind chill is " + windChill);

            if (temperature > 50)
            {
                int RH;

                Console.WriteLine("Enter the relative humidity");
                input = Console.ReadLine();
                RH = int.Parse(input);

                double HI = 0.5 * (temperature + 61) + (temperature - 68) * 1.2 + (RH * 0.094);
                

                Console.WriteLine("The Heat Index is" + HI);
            }
            else
            {
                Console.WriteLine("Enter the wind speed");
                input = Console.ReadLine();
                windSpeed = int.Parse(input);

                windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is" + windChill);
            }

        }
    }
}