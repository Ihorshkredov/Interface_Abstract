using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class MeteoCenter
    {
        public Temperature [] MeteoData { get; }


        public MeteoCenter(Weather weather)
        {
            MeteoData = MonitorWeather(weather);
        }


        public Temperature[] MonitorWeather(Weather weather)
        {
            Temperature[] temperatures = new Temperature [weather.Period];  

            for (int i = 0; i < weather.Period ; i++)
            {
                temperatures[i] = new Temperature(weather.Temps[i],$"After {i+1} day from today");
            }
            return temperatures;
        }

        public void GetTemperatureByDate(short inWhatDay)
        {
            Console.WriteLine($"MeteoCenter prognoze on the {inWhatDay} day after today:");
            MeteoData[inWhatDay].GetInfo();

        }


        public void GetTemperatureByPeriod(short dayFrom, short dayTo)
        {
            if (dayFrom > MeteoData.Length || dayTo > MeteoData.Length)
            {
                Console.WriteLine("Prognoze impossible. No meteo data for this day");

            }
            else
            {
                Console.WriteLine($"MeteoCenter prognoze on period from {dayFrom} day " +
                    $"after today on the next {dayTo - dayFrom} days");
                for (int i = dayFrom; i < dayTo; i++)
                {
                    Console.Write($"Day {i+1} - ");
                    MeteoData[i].GetInfo(); 

                }
            }
            
            
        }

    }
}
