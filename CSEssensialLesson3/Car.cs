using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEssensialLesson3
{
     abstract class Car:IVehicle,IRecycable
    {
        public string Colour { get; set; }
        public string Model { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"This car's model:{Model}, colour - {Colour}");
        }

        public virtual void CarryPeople ()
        {
            Console.WriteLine("Can cary some quantity of people ");
            
        }

        public virtual void CarryLaggage()
        {
            Console.WriteLine("Can carry some weight of laggage ");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Br...br...br");
        }

        public virtual void RecycleToMetal()
        {
            Console.WriteLine("Bzhyk...cutted to metal spare parts");

        }

    }
}
