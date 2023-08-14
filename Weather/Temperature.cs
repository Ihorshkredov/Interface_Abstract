using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal struct Temperature
    {
        
        public string Date { get; }
        public int Celcius { get; }
        public double Kelvin{ get;  }  
        public double Farenheit {get; }
     

        public Temperature(int temperature, string  date)
        {
            Celcius = temperature;
            Date = date;
            Kelvin = temperature - 272.15;
            Farenheit = temperature - 17.22;    

        }

        public void GetInfo() => Console.WriteLine($" Temperature is: {Celcius} C , {Farenheit} F, {Kelvin} K ");
            
        
        


        

    }
}
