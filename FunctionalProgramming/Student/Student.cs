using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{

    //Create a class Student with properties FirstName, LastName, Age, 
    //FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber. Create a List<Student>
    //    with sample students. These students will be used for the next few tasks.
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, int age, string facNum, string phone, string email, IList<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facNum;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

    }
}
