

using System.Reflection;
using System.Runtime;
using System.Xml.Linq;

namespace _111.NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, Car> allCars = new Dictionary<string, Car>();

            int count = int.Parse(Console.ReadLine());
            string input = string.Empty;

            for (int i = 0; i < count; i++)
            {
                input = Console.ReadLine();
                string[] arguments=input.Split("|").ToArray();
                string name=arguments[0];
                Car newCar = new Car(name, int.Parse(arguments[1]), int.Parse(arguments[2]));
                allCars.Add(name, newCar);

            }

            while ((input=Console.ReadLine())!="Stop")
            {
                string[] commands = input.Split(" : ").ToArray();
                string command = commands[0];

                switch (command)
                {
                    case "Drive":
                        string name = commands[1];
                        int distance = int.Parse(commands[2]);
                        int fuel=int.Parse(commands[3]);
                        DriveMethod(allCars, name,distance, fuel);
                        break;
                    case "Refuel":
                        string model=commands[1];
                        int fuelForRefuel = int.Parse(commands[2]);
                        RefuelMethod(allCars, model, fuelForRefuel);
                        break;
                    case "Revert":
                        string modelCar=commands[1];
                        int kilometers=int.Parse(commands[2]);
                        RevertMethod(allCars, modelCar, kilometers);
                        break;

                }

            }

            foreach (Car car in allCars.Values)
            {
                Console.WriteLine($"{car.CarModel} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }

        private static void RevertMethod(Dictionary<string, Car> allCars, string modelCar, int kilometers)
        {
            if (allCars.ContainsKey(modelCar))
            {
                allCars[modelCar].Mileage -= kilometers;
                if (allCars[modelCar].Mileage<10000)
                {
                    allCars[modelCar].Mileage = 10000;
                    return;
                }
                Console.WriteLine($"{modelCar} mileage decreased by {kilometers} kilometers");
            }
        }

        private static void RefuelMethod(Dictionary<string, Car> allCars, string model, int fuelForRefuel)
        {
            if (allCars.ContainsKey(model))
            {
                int currentFuel = allCars[model].Fuel;
                if (currentFuel+fuelForRefuel>75)
                {
                    
                    Console.WriteLine($"{model} refueled with {75-currentFuel} liters");
                    allCars[model].Fuel = 75;
                    return;
                }
                allCars[model].Fuel+=fuelForRefuel;
                Console.WriteLine($"{model} refueled with {fuelForRefuel} liters");
            }
        }

        private static void DriveMethod(Dictionary<string, Car> allCars, string name, int distance, int fuel)
        {
            if (allCars.ContainsKey(name))
            {
                if (allCars[name].Fuel<fuel)
                {
                    Console.WriteLine("Not enough fuel to make that ride");
                }
                else
                {
                    allCars[name].Fuel-=fuel;
                    allCars[name].Mileage += distance;
                    Console.WriteLine($"{name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    if (allCars[name].Mileage>=100000)
                    {
                        Console.WriteLine($"Time to sell the {name}!");
                        allCars.Remove(name);
                    }
                }
            }
        }
    }

    class Car 
    {
        public Car(string carModel, int mileage, int fuel)
        {
            CarModel = carModel;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string CarModel { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
