using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _6._1
{
    class MoblibePhone // class
    {
        // properties of the class /object
        public string brand { get; set; }
        public string model { get; set; }
        public int storage { get; set; }
        public int price { get; set; }

        public MoblibePhone(string brand, string model, int storage, int price)
        {
            this.brand = brand;
            this.model = model;
            this.storage = storage;
            this.price = price;
        }
        // Display Info
        public virtual void DisplayInfo()
        {
            Console.WriteLine($" {brand} -- {model} -- {storage} -- {price} ");

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //MoblibePhone Info
            MoblibePhone mobliephone = new MoblibePhone("Apple", "iPhone 10", 280, 1000);
            mobliephone.DisplayInfo();


            MoblibePhone mobilephone2 = new MoblibePhone("Samsung", "Fold3", 450, 899);
            mobilephone2.DisplayInfo();


        }

    }
}
