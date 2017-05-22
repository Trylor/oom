using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]

    class Test
    {
        [Test]
        public void default_values_device()
        {
            device test1 = new device("Testgerät");
            Assert.IsTrue(test1.Name == "Testgerät");
            Assert.IsTrue(test1.Type == "default");
            Assert.IsTrue(test1.Producer == "default");
        }
        [Test]
        public void success_change_IP_LAN_WiFi()
        {
            device test1 = new device("Testgerät");
            test1.LAN = true;
            test1.update_IP("100.20.20.20", false);
        }
        [Test]
        public void invalid_IP()
        {
            Assert.Catch(() =>
            {
                device test1 = new device("Testgerät");
                test1.LAN = true;
                test1.update_IP("300.20.20.20", false);         
            });
        }
        [Test]
        public void set_IP_no_LAN_WiFi()
        {
            Assert.Catch(() =>
            {
                device test1 = new device("Testgerät");
                test1.update_IP("100.20.20.20", false);
            });
        }
        [Test]
        public void default_values_furniture()
        {
            furniture test1 = new furniture("Testtisch","Tisch");
            Assert.IsTrue(test1.Name == "Testtisch");
            Assert.IsTrue(test1.Type == "Tisch");
            Assert.IsTrue(test1.Producer == "");
            Assert.IsTrue(test1.Warranty_duration == 2);
        }

        [Test]
        public void warranty()
        {
            device test1 = new device("Testgerät", "testype", "noname", false, false, "", DateTime.Now.Date, 1, 25, "0.0.0.0", "0.0.0.0");
            Assert.IsTrue(test1.warranty_until() == DateTime.Now.Date.AddYears(1));
        }

        [Test]
        public void objekt_test()
        {
            furniture test1 = new furniture("Schrank Schlafzimmer tief", "PAX", "IKEA", DateTime.Parse("25.02.2017"), 4);
            furniture test2 = new furniture("Schrank Schlafzimmer tief", "PAX", "IKEA", DateTime.Parse("25.02.2017"), 4);

            Assert.AreSame(test1, test2);
        }

        [Test]
        public void value_test()
        {
            furniture test1 = new furniture("Schrank Schlafzimmer tief", "PAX", "IKEA", DateTime.Parse("25.02.2017"), 4);

            Assert.IsTrue(test1.Name == "Testtisch");
            Assert.IsTrue(test1.Type == "Tisch");
            Assert.IsTrue(test1.Producer == "");
            Assert.IsTrue(test1.Warranty_duration == 2);
        }



    }
}
