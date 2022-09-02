using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    internal class Program
    {
        public static void Main(string[] cmd)
        {

            try
            {
                Order order = new Order();
                Console.WriteLine("Nhập tên :");
                String name = Console.ReadLine();
                Customer customer = new Customer(name);

                Console.WriteLine("Welcome come " + name + " to my Store:");
                Console.WriteLine("What do you buy ?\n1. grocery item\n2. bakery");
                int chon = int.Parse(Console.ReadLine());
                int many = 0;
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Grocery Item:\n how many ??:");
                        many = int.Parse(Console.ReadLine());
                        Console.WriteLine("price : " + (order.Grocery * many));
                        break;
                    case 2:
                        Console.WriteLine("Grocery Item:\n how many ??:");
                        many = int.Parse(Console.ReadLine());
                        Console.WriteLine("Your bill: Guest name : " + (customer.Name) + "\nprice : " + (order.Bakery * many));
                        break;
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
