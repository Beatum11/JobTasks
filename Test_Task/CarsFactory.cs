using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task
{
    internal class CarsFactory
    {
        public Car Create(string typeOfCar)
        {

            switch (typeOfCar)
            {
                case "Sport":
                    return new SportCar(typeOfCar);

                case "Truck":
                    return new Truck(typeOfCar);

                case "Passenger":
                    return new PassCar(typeOfCar);

                default:
                    return null;
            }
        }


    }
}
