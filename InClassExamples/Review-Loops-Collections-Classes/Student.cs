using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Loops_Collections_Classes
{
    class Student
    {
         public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        private int LuckyNumber;

       public Student()
        {
            ID = 0;
            Firstname = "";
            Lastname = "";
            Birthdate = DateTime.Now;
            LuckyNumber = 0;
        }

        public Student(int id, int luckyNumber)
        {
            ID = id;
            Firstname = "";
            Lastname = "";
            Birthdate = DateTime.Now;
            LuckyNumber = luckyNumber;
        }

        public string BirthdateDayOfWeek()
        {

            return "";
        }





    }
}
