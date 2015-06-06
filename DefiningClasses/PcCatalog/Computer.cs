using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcCatalog
{
    class Computer
    {
        private string name;
        private List<Component> components;
        private decimal price;
        public List<Component> Components { get { return components; } set { components = value; } }
        public decimal Price { get { return price; } set { price = value; } }
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

        public Computer(string name)
        {
            this.Name = name;
            this.Components = new List<Component>();
            this.AddComponents(Components);
            this.Price = Components.Sum(x => x.Price);
        }

        private void AddComponents(List<Component> comps)
        {
            bool addMore = true;

            while (addMore)
            {
                Console.WriteLine("Enter component name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter details(Optional): ");
                string details = Console.ReadLine();

                comps.Add(new Component(name, price, details));

                Console.WriteLine("Enter more parts?  Y/N");
                addMore = Console.ReadLine() == "Y";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + this.Name + "\n Components: \n");
            foreach (var item in Components)
            {
                sb.Append("Name: " + item.Name + " Price: " + item.Price + " Details: " + item.Details + "\n");
            }
            sb.Append("Total Price: " + this.Price);

            return string.Format(sb.ToString());
        }
    }
}
