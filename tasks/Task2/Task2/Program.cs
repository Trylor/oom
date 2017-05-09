using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            device Test = new device("Fernseher");
            device test2 = new device("Laptop", "Aspire", "Acer", true, true, "", DateTime.Parse("25.03.2016"), 4, 500, "192.168.1.1", "192.168.1.2");


            Test.print_all();
            Console.WriteLine("");
            test2.print_all();

            Console.WriteLine("");
<<<<<<< HEAD
            Console.WriteLine("Ändere bei Fernseher Kaufdatum auf 2.05.2017");
=======
            Console.WriteLine("Änder bei Fernseher Kaufdatum auf 2.05.2017");
>>>>>>> 9152eacc0a8d456cdd8ea5ca188e14702d47eaa6
            Test.Purchasedate = DateTime.Parse("02.05.2017");
            Console.WriteLine("Änder bei Fernseher IP LAN auf 10.0.0.1");
            Test.update_IP_LAN("10.0.0.1");
            //Test.LAN = true;
            //Test.update_IP_LAN("10.0.0.1");
            Console.WriteLine("");
            Test.print_all();





        }
    }
}
