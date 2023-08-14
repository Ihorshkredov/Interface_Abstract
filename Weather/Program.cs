namespace Weather
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Weather summerWeather = new Weather(10, "Summer");
            MeteoCenter meteoCenter = new MeteoCenter(summerWeather);

            meteoCenter.GetTemperatureByPeriod(3,7);
            Console.WriteLine(new string('-', 30));
            meteoCenter.GetTemperatureByDate(5);

            

            
        }
    }
}