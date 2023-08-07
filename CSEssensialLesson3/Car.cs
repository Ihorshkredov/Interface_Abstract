using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEssensialLesson3
{
     abstract class Car: IVehicle, IRecycable
    {
        public string Colour { get; }
        public string Model { get; }
        public Car(string colour, string model)
        {
            Colour = colour;
            Model = model;
        }

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

        public abstract void Drive();
       
        public virtual void RecycleToMetal()
        {
            Console.WriteLine("Bzhyk...cutted to metal spare parts");

        }

    }
}
