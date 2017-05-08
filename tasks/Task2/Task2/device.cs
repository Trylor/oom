using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class device
    {

        public device(string name)
            :this(name,"default", "default",false,false,"",DateTime.Now,0,0,"000.000.000.000","000.000.000.000")
        {
            
        }

        public device(string name, string type, string producer, Boolean has_LAN,Boolean has_WiFi, string serialnumber, DateTime purchasedate, int warranty_duration, decimal price, string ip_LAN, string ip_WiFi)
        {
            Name = name;
            Type = type;
            Producer = producer;
            WiFi = has_WiFi;
            LAN = has_LAN;
            Serialnumber = serialnumber;
            Purchasedate = purchasedate;
            Warranty_duration = warranty_duration;
            Price = price;
            update_IP_LAN(ip_LAN);
        }


        public string Name { get; set; }
        public string Type { get; set; }
        public string Producer { get; set; }

        public Boolean WiFi { get; set; }
        public Boolean LAN { get; set; }



        public string Serialnumber { get; set; }
        public DateTime Purchasedate { get; set; }
        public DateTime warranty_until()
        {
            return DateTime.Now;
        }
        private int Warranty_duration{ get; set; }

        private decimal Price;
        private string IP_adress_LAN;


        public void update_IP_LAN(string ip)
        {
            if (!LAN)
            {
                LAN = true;
                //throw new Exception("LAN ist nicht verfügbar!");
            }

            if (ip.Length > 15) { throw new ArgumentException("IP ungültig", nameof(ip)); };
            var ip_str = ip.Split('.');
            if (int.Parse(ip_str[0]) > 255) { throw new ArgumentException("IP ungültig", nameof(ip)); };
            if (int.Parse(ip_str[1]) > 255) { throw new ArgumentException("IP ungültig", nameof(ip)); };
            if (int.Parse(ip_str[2]) > 255) { throw new ArgumentException("IP ungültig", nameof(ip)); };
            if (int.Parse(ip_str[3]) > 255) { throw new ArgumentException("IP ungültig", nameof(ip)); };

            IP_adress_LAN = ip;

        }

        public void print_all()
        {
            Console.WriteLine("Device name: " + Name);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Producer: " + Producer);
            Console.WriteLine("has LAN: " + LAN);
            Console.WriteLine("has WiFi: " + WiFi);
            Console.WriteLine("Serialnumber: " + Serialnumber);
            Console.WriteLine("Purchase date: " + Purchasedate);
            Console.WriteLine("Warranty until: " + warranty_until());
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("IP LAN: " + IP_adress_LAN);

        }



    }
}
