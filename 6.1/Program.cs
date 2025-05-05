using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _6._1
{
    class MobilePhone// the class for the Mobile phone
    {
        //These are the properties for each object
        public string brand { get; set; }
        public string model { get; set; }
        public int storage { get; set; }
        public int price { get; set; }

        public MobilbePhone(string brand, string model, int storage, int price) // identify each object for the Mobile phone
        {
            this.brand = brand;
            this.model = model;
            this.storage = storage;
            this.price = price;
        }
        public virtual void DisplayInfo() // The display the phone information
        {
            Console.WriteLine($" {brand} -- {model} -- {storage} -- {price} ");

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // The first mobile phone display
            MobilePhone mobilephone = new MobilePhone ("Apple", "iPhone 10", 280, 1000);
            mobilephone.DisplayInfo();

            // The second mobile phone display
            MobilbePhone mobilephone2 = new MoblibePhone("Samsung", "Fold3", 450, 899);
            mobilephone2.DisplayInfo();


        }

    }
}
