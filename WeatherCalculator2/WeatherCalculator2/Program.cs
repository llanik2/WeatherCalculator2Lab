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
            int RelHumidity;
            double HeatInd;
            double windChill;
            string input = "";

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature");

            input = Console.ReadLine();

            temperature = int.Parse(input);

            // Detect if over 50 degrees
            if(temperature > 50)
            {
                Console.WriteLine("Enter the relitive humidity");

                input = Console.ReadLine();

                RelHumidity = int.Parse(input);

                HeatInd = .5 * (temperature + 61 + ((temperature - 68) * 1.2) + (RelHumidity * 0.094));
            }
            else
            {
                // Get the windspeed from the user
                Console.WriteLine("Enter the wind speed");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);

                // Calculate the wind chill

                windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is " + windChill);
            }
        }
    }
}
