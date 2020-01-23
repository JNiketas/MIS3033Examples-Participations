//John Niketas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Loops_Collections_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Example
            int[] StudentIds = new int[3];
            string[] FirstNames = new string[3];
            string[] LastNames = { "Harris", "Ackerman","Smith" };
            StudentIds[0] = 1;
            StudentIds[1] = 2;
            StudentIds[2] = 3;
            FirstNames[0] = "Katie";
            FirstNames[1] = "Adam";
            FirstNames[2] = "Harry";

            for (int i = 0; i < StudentIds.Length; i++)
            {
                Console.WriteLine($"{LastNames[i]}, {FirstNames[i]} [{StudentIds[i]}]");
            }

            //Dictionary Example - key/value pairs
            Dictionary<int, string> students = new Dictionary<int, string>();
                     //key, value
            students.Add(1, "Katie Harris");
            students.Add(2, "Adam Ackerman");
            students.Add(3, "Harry Smith");

            //Makes sure a key doesnt already exist in the dictionary
            //if (students.ContainsKey(1))
            //{
            //    students[1] = "SOME NEW VALUE";
            //}
            //else
            //{
            //    students.Add(1, "Some Value");
            //}

            foreach (var key in students.Keys)
            {
                Console.WriteLine($"{students[key]} [{key}].");
            }


            List<Student> studs = new List<Student>();

            Student katie = new Student();
            katie.Firstname = "Katie";
            katie.Lastname = "Harris";
            katie.ID = 1;
            katie.Birthdate = Convert.ToDateTime("3/11/1998");

            studs.Add(katie);

            for (int i = 0; i < StudentIds.Length; i++)
            {
                Student s = new Student();
                s.Firstname = FirstNames[i];
                s.Lastname = LastNames[i];
                s.ID = StudentIds[i];

                studs.Add(s);
            }

            foreach (var student in studs)
            {
                Console.WriteLine($"{LastNames} , {FirstNames} [{StudentIds}] was born on {student.Birthdate.ToLongDateString()}");
            }

           
            Console.ReadKey();


        }
    }
}
