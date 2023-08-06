using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEssensialLesson3
{
    internal class Truck: Car
    {
        public new void CarryPeople()
        {
            Console.WriteLine("Truck can carry 2 pasangers ");
        }

        public new void CarryLaggage()
        {
            Console.WriteLine("Truck can carry big amount of things.Few tonns. ");
        }

        public new void Drive()
        {
            Console.WriteLine("Wrum - wrum - wrum...I have tons of laggage, speed is 70 km/h");
        }

    }
}
