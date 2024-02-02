using ConsoleApp5.Entities;

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
            Console.Write("Status: ");             //Do this <<<<<

            DateTime orderTime = DateTime.Now;

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
        }
    }
}
