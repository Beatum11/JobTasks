using Test_Task;


CarsFactory carsFactory = new CarsFactory();
List<Car> cars = new List<Car>();

for (int i = 0; i < 3; i++)
{
    Console.Write($"\nCreate a new car: ");
    string typeOfCar = Console.ReadLine();
    cars.Add(carsFactory.Create(typeOfCar));
}

var sportCar = cars.Where(c => c.TypeOfCar == "Sport").First();


#region Random data for a sport car.

sportCar.FuelCapacity = 55f;
sportCar.FuelConsump = 8f;
sportCar.Speed = 80;
sportCar.PassAmount = 3;

#endregion


var distance = sportCar.DistanceCount(sportCar.FuelCapacity, sportCar.FuelConsump);
Console.WriteLine($"\nDistance that car can ride: {distance} km.");


var extraParams = sportCar.PassWeightCount();
var result = sportCar.DistanceInfo(distance, extraParams);
Console.WriteLine($"\nHow many kilometers left: {result} km.");


sportCar.DistanceTime(sportCar.FuelCapacity, 400);