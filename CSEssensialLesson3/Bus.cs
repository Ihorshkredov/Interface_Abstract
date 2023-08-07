using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEssensialLesson3
{
    internal class Bus:Car, IVehicle, IRecycable
    {
        public Bus(string colour, string model) : base(colour, model)
        {

        }

        public new void CarryPeople()
        {
            Console.WriteLine("Bus can carry 50 pasangers ");  
        }

        public new void CarryLaggage() 
        {
            Console.WriteLine("Bus can carry small amount of things. One bag for every pasanger");
        }

        public override void Drive()
        {
            Console.WriteLine("You drive on the speed 80 km/h");
        }
    }
}
