using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {


            var items = new objekt[]
            {
                new device("Fernseher"),
                new device("Laptop", "Aspire", "Acer", true, true, "", DateTime.Parse("25.03.2016"), 4, 500, "192.168.1.1", "192.168.1.2"),
                new furniture("Charlys","Schreibtisch"),
                new furniture("Schrank Schlafzimmer tief", "PAX", "IKEA", DateTime.Parse("25.02.2017"), 4),
                new device("Testgerät","testype","noname",false,false,"",DateTime.Now.Date,0,25,"0.0.0.0","0.0.0.0")
            };


            IEnumerable<objekt> en = new List<objekt> (items);
 




            //foreach (var x in items)
            //{
            //    Console.WriteLine("Garantie gültig bis: " + x.warranty_until());
            //}

            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            //Console.WriteLine(JsonConvert.SerializeObject(items, settings));

            // Serialize Array of Items
            var text = JsonConvert.SerializeObject(items, settings);
            var target = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filename = Path.Combine(target, "task2_export.json");
            File.WriteAllText(filename, text);



            // De-Serialize Array of Items
            //filename = Path.Combine(target, "task2_import.json");
            var read_file = File.ReadAllText(filename);
            var read_items = JsonConvert.DeserializeObject<objekt[]>(read_file, settings);

            foreach (var x in read_items)
            {
                //Console.WriteLine("Garantie gültig bis: " + x.warranty_until());
                x.print_all();
            }


            var items2 = new objekt[0];
            push.Run(items2);

            foreach (var x in items2)
            {
                Console.WriteLine("Name:" + x.Name);
            }




            #region test1

            //device Test = new device("Fernseher");
            //device test2 = new device("Laptop", "Aspire", "Acer", true, true, "", DateTime.Parse("25.03.2016"), 4, 500, "192.168.1.1", "192.168.1.2");


            //Test.print_all();
            //Console.WriteLine("");
            //test2.print_all();



            //Console.WriteLine("");
            //Console.WriteLine("Änder bei Fernseher Kaufdatum auf 2.05.2017");
            //Test.Purchasedate = DateTime.Parse("02.05.2017");
            //Console.WriteLine("Änder bei Fernseher IP LAN auf 10.0.0.1");
            //Test.update_IP("10.0.0.1",false);
            ////Test.LAN = true;
            ////Test.update_IP_LAN("10.0.0.1");
            //Console.WriteLine("");
            //Test.print_all();

            //furniture Teil1 = new furniture("Charlys","Schreibtisch");
            //furniture Teil2 = new furniture("Schrank Schlafzimmer tief", "PAX", "IKEA", DateTime.Parse("25.02.2017"), 4);

            //Teil1.print_all();
            //Teil2.print_all();
            #endregion

        }
    }
}
