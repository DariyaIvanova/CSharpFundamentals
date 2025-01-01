
using System.Xml.Linq;

namespace _03.Orders
{
    internal class Program
    {
        class Product
        {
            public Product(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }

            public string Name {get; set;}
            public double Price {get; set;}
            public int Quantity {get; set;}

            public override string ToString()
            {
                string result = $"{Name} -> {Price*Quantity:f2}";
                return result ;
            }

            public void Update(double price, int quantity)
            {
                Price = price;
                Quantity += quantity;    
            }
        }
        
        static void Main(string[] args)
        {
            Dictionary<string, Product> products=new Dictionary<string, Product>();

            string input=string.Empty;
            while ((input=Console.ReadLine())!="buy")
            {
                string[] arguments = input.Split();
                string name=arguments[0];
                double price = double.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]);


                if (products.ContainsKey(name))
                {
                    products[name].Update(price, quantity);
                   
                }
                else
                {
                    var product = new Product(name, price, quantity);
                   

                    products.Add(name, product);
                }
            }

            foreach (Product product in products.Values)
            {
                Console.WriteLine(product);
            }
        }
    }
}
