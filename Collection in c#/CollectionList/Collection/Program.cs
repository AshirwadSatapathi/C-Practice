using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
       //static List<student> a = new List<student>();

        static void Main(string[] args)
        {
            List<student> a = new List<student>();

            student a1 = new student();
            a1.studentID = 1;
            a1.studentName = "Ashirwad";
            a1.studentEmail = "ashirwad@esspl.com";
            a.Add(a1);

            student a2 = new student();
            a2.studentID = 2;
            a2.studentName = "Deepak";
            a2.studentEmail = "deepak@esspl.com";
            a.Add(a2);

            student a3 = new student();
            a3.studentID = 3;
            a3.studentName = "Nicolas";
            a3.studentEmail = "nicolas@esspl.com";
            a.Add(a3);

            student a4 = new student();
            a4.studentID = 4;
            a4.studentName = "Ashutosh";
            a4.studentEmail = "ashutosh@esspl.com";
            a.Add(a4);

            foreach (var i in a) {
                Console.WriteLine(i.studentID+" "+i.studentName+" "+i.studentEmail);
            }
            Console.ReadLine();
        }
    }
    class student {

        public int studentID { get; set; }
        public string studentName { get; set; }
        public string studentEmail { get; set; }
        
    }

}
