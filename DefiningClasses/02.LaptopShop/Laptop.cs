using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private decimal price;
        private Battery battery;

        public decimal Price
        {
            get { return price; }
            set
            {
                try
                {
                    if (value > 0)
                    {
                        price = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Parameter cannot be null or negative");
                }
            }
        }
        public string Screen
        {
            get { return screen; }
            set
            {
                try
                {
                    if (value != null)
                    {
                        screen = value;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Parameter cannot be null");
                }
            }
        }
        public string Hdd
        {
            get { return hdd; }
            set
            {
                try
                {
                    if (value != null)
                    {
                        hdd = value;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Parameter cannot be null");
                }
            }
        }
        public string GraphicsCard
        {
            get { return graphicsCard; }
            set
            {
                try
                {
                    if (value != null)
                    {
                        graphicsCard = value;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Parameter cannot be null");
                }
            }
        }
        public string Ram
        {
            get { return ram; }
            set
            {
                try
                {
                    if (value != null)
                    {
                        ram = value;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Parameter cannot be null");
                }
            }
        }
        public string Processor
        {
            get { return processor; }
            set
            {
                try
                {
                    if (value != null)
                    {
                        processor = value;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Parameter cannot be null");
                }
            }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                try
                {
                    if (value != null)
                    {
                        manufacturer = value;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Parameter cannot be null");
                }
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                try
                {
                    if (value != null)
                    {
                        model = value;
                    }
                    else
                    {
                        throw new System.ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Parameter cannot be null");
                }

            }
        }

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
            battery = new Battery();
        }

        public Laptop(string model, string manufacturer, string processor, string ram, string graphicsCard, string hdd, string screen, string batteryName, string batteryLife, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Price = price;
            battery = new Battery(batteryName, batteryLife);
        }

        public override string ToString()
        {
            return string.Format("Model: {0} \n Manufacturer: {1} \n Processor: {2} \n RAM: {3} \n Graphics Card: {4} \n HDD: {5} \n Screen: {6} \n Battery: {7} \n Battery life: {8} \n Price: {9:0.00}лв",
                this.Model, this.Manufacturer, this.Processor, this.Ram, this.GraphicsCard, this.Hdd, this.Screen, this.battery.BatteryName, this.battery.BatteryLife, this.Price);
        }



        private class Battery
        {
            private string batteryName;
            private string batteryLife;

            public string BatteryLife
            {
                get { return batteryLife; }
                set
                {
                    try
                    {
                        if (value != null)
                        {
                            batteryLife = value;
                        }
                        else
                        {
                            throw new ArgumentException();
                        }
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Parameter cannot be null");
                    }
                }
            }
            public string BatteryName
            {
                get { return batteryName; }
                set
                {
                    try
                    {
                        if (value != null)
                        {
                            batteryName = value;
                        }
                        else
                        {
                            throw new ArgumentException();
                        }
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Parameter cannot be null");
                    }
                }
            }
            public Battery() { }
            public Battery(string batteryName, string batteryLife)
            {
                this.BatteryName = batteryName;
                this.BatteryLife = batteryLife;
            }
        }


        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop("model nov", "manufacturer", "processor123", "8GB ram", "graphics 4600", "120 hdd", "18inch screen", "battery name", "5 hours battery life", 125);

            Laptop laptop2 = new Laptop(null, "manufacturer", "processor123", "8GB ram", "graphics 4600", "120 hdd", "18inch screen", "battery name", "5 hours battery life", 125);
            Laptop laptop3 = new Laptop("Model", 123.96M);
            Console.WriteLine(laptop1);
            Console.WriteLine(laptop2);
            Console.WriteLine(laptop3);
        }
    }
}
