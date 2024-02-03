using ConsoleApp5.Entities;
using ConsoleApp5.Entities.Enums;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birthdate DD/MM/YYYY: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(nome, email, birthDate);

            Console.WriteLine("\nEnter Order data:");
            Console.Write("Status: "); 
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            DateTime orderTime = DateTime.Now;

            Order order = new Order(orderTime, status);

            Console.Write("\nHow many items to this order? ");
            byte n = byte.Parse(Console.ReadLine());

            List<OrderItem> orders = new List<OrderItem>();
            List<Product> products = new List<Product>();
       
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter {i+1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                orders.Add(new OrderItem(quantity,productPrice));
                products.Add(new Product(productName, OrderItem.SubTotal(productPrice, quantity)));
            }
            Console.WriteLine("\nORDER SUMMARY:\n");
            Console.WriteLine(order);
            Console.WriteLine(client);


        }
    }
}
