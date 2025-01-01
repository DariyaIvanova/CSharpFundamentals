namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Truck
    {
        public  string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }

    public class Catalog
    {
        public List<Car> ListCars { get; set; }
        public List<Truck> ListTrucks { get; set; }
    }
}
