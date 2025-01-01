namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Box> boxes = new List<Box>();

            while ((input=Console.ReadLine())!="end")
            {
                string[] arguments = input.Split().ToArray();

                //"{Serial Number} {Item Name} {Item Quantity} {itemPrice}"

                Box box = new Box
                {
                    SerialNumber = arguments[0],
                    Item =new Item(arguments[1], decimal.Parse(arguments[3])),
                    ItemQuantity = int.Parse(arguments[2])
                };

                boxes.Add(box);
            }

            List<Box> sortedListBoxes = boxes.OrderByDescending(box=>box.Price).ToList();
            foreach (Box box in sortedListBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }
        }
    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal Price
        {
            get
            {
                return ItemQuantity * Item.Price;
            }
         
        }
    }
}
