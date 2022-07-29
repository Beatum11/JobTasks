using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task
{
    internal abstract class Car
    {

        #region Fields
        public string TypeOfCar { get; set; }

        public float FuelConsump { get; set; }

        public float FuelCapacity { get; set; }

        public int Speed { get; set; }

        public float PassAmount { get; set; }

        #endregion


        #region Constructors

        public Car(string typeOfCar)
        {
            TypeOfCar = typeOfCar;
        }

        #endregion


        #region Methods

        /// <summary>
        /// It counts how many km car can ride
        /// with a certain amount of fuel.
        /// </summary>
        /// <param name="fuelCap"></param>
        /// <param name="fuelCons"></param>
        /// <returns></returns>
        public float DistanceCount(float fuelCap, float fuelCons)
        {
            var res = fuelCap / fuelCons;
            res *= 100;
            return res;
        }


        /// <summary>
        /// It counts how many kilometers left 
        /// with a certain extra params.
        /// </summary>
        /// <param name="posDistance"></param>
        /// <param name="extraParam"></param>
        /// <returns></returns>
        public float DistanceInfo(float distance, float extraParam)
        {
            var procent = (distance / 100) * extraParam;
            var res = distance - procent;

            return res;
        }


        /// <summary>
        /// Сounts how many hours it will take
        /// to travel a certain distance.
        /// </summary>
        /// <param name="fuelCap"></param>
        /// <param name="distance"></param>
        public void DistanceTime(float fuelCap, float distance)
        {
            
            var distCheck = DistanceCount(fuelCap, FuelConsump);

            if(distance > distCheck)
                Console.WriteLine("Your car won't make it");
            else
            {
                var time = distance / Speed;
                Console.WriteLine($"Your car will arrive in {time} hours!");
            }
        }

        public float PassWeightCount()
        {
            float percent = PassAmount * 6;
            return percent;
        }

        #endregion




    }
}
