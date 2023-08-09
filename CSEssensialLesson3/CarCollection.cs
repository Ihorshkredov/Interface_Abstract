using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEssensialLesson3
{
    internal class CarCollection
    {
        SportCar [] collection = new SportCar[5];

        public SportCar this[ int index ]
        {
            get { return collection[index] ; }
            set { collection[index] = value; }
        }

    }
}
