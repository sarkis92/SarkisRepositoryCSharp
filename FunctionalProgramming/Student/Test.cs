using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Test
    {


        public static void Main()
        {
            var marks = new List<int>();
            marks.Add(3);
            marks.Add(4);
            marks.Add(5);
            marks.Add(2);
            marks.Add(4);
            marks.Add(4);
            marks.Add(6);

            List<Student> students = new List<Student>();

            students.Add(new Student("pesho", "peshev", 21, "121233344", "0889573219", "dsa@abv.bg", marks, 45));
            students.Add(new Student("mariq", "ignatova", 22, "121233352", "0889573237", "ddsagsa@abv.bg", marks, 45));
            students.Add(new Student("atanas", "peshev", 21, "121233344", "0889573219", "dsa@abv.bg", marks, 45));
            students.Add(new Student("pesho", "pesho", 21, "121233344", "0889573219", "dsa@abv.bg", marks, 45));
            students.Add(new Student("dsadsa", "dsadsa", 11, "121233344", "0889573219", "dsa@abv.bg", marks, 45));

            // students in group 45 ordered by name
            Console.WriteLine("students in group 45 ordered by name");
            var querry = students.Where(x => x.GroupNumber == 45).OrderBy(student => student.FirstName).Select(student => student);

            foreach (var student in querry)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }



            Console.WriteLine();
            //Print all students whose first name is before their last name alphabetically
            Console.WriteLine("Print all students whose first name is before their last name alphabetically");
            var query2 = students.Where(student => (student.FirstName.CompareTo(student.LastName)) != 1).Select(student => student);

            foreach (var student in query2)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            Console.WriteLine("Write a LINQ query that finds the first name and last name of all students with age between 18 and 24");
            var query3 = students.Where(student => student.Age > 18 && student.Age < 34)
                .Select(student => new { student.FirstName, student.LastName, student.Age });
            foreach (var student in query3)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }

            Console.WriteLine();
            //Print all students that have at least one mark Excellent (6)

            Console.WriteLine("Print all students that have at least one mark Excellent (6)");
            var query4 = students.Select(student => new { student.FirstName, student.LastName, student.Marks }).Where(student => student.Marks.Contains(6)).Select(student => student);

            foreach (var student in query4)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + string.Join(" ", student.Marks));
            }
        }
    }
}
