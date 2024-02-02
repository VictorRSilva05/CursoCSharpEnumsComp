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

            Console.WriteLine("Enter Order data:");
            Console.Write("Status: "); 
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            DateTime orderTime = DateTime.Now;

            Order order = new Order(orderTime, status);

            Console.Write("How many items to this order? ");
            byte n = byte.Parse(Console.ReadLine());
       
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i+1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(order);
            Console.WriteLine(client);
        }
    }
}
