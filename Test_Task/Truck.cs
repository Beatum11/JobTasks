using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task
{
    internal class Truck : Car
    {
        public Truck(string typeOfCar) : base(typeOfCar)
        {

        }


        public int Weight { get; set; }

        public float WeightCount()
        {
            float percent = Weight * 0.02f;
            return percent;
        }


    }
}
