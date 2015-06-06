using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcCatalog
{
    class Component
    {
        private string name;
        private decimal price;
        private string details;
        public string Details { get { return details; } set { details = value; } }
        public string Name
        {
            get { return name; }

            set
            {
                try
                {
                    if (value != null)
                    {
                        name = value;
                    }
                    else
                    {
                        throw new ArgumentNullException();
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Parameter can not be null");
                }
            }
        }
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
                    Console.WriteLine("Price must be positive!");
                }
            }
        }
        public Component(string name, decimal price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.details = details;
        }
    }
}
