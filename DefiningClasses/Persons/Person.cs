using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Person
    {

        private string name;
        private int age;
        private string email;
        public string Name 
        { 
            get { return name; }
            
            set
            { 
                if (value == null)
	            {
		            throw new Exception("invalid name");
	            }
                else
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new Exception("invalid age");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (email == null || email.Contains('@'))
                {
                    email = value;
                }
                else
                {
                    throw new Exception("invalid email");
                }
            }
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null) { }


        public override string ToString()
        {
            return string.Format(this.Name + " " + this.Age + " " + this.Email);
        }


        static void Main(string[] args)
        {
            Person ob = new Person("Pesho", 12);
            Person ob2 = new Person("Gosho", 22, "gosho@mail.com");
            Console.WriteLine(ob);
            Console.WriteLine(ob2);
        }
    }
}
