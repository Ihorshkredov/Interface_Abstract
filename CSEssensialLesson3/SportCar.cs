using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEssensialLesson3
{
    internal class SportCar:Car
    {
        public new void CarryPeople()
        {
            Console.WriteLine("Sport-car can carry maximum 2  pasangers ");
        }

        public new void CarryLaggage()
        {
            Console.WriteLine("Sport car almost never takes laggage");
        }

        public new void Drive()
        {
            Console.WriteLine("Weeeeee.... I'm runing on speed more then 180 km/h");
        }
    }
}
