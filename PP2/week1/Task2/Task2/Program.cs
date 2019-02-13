using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    public class Student
    {
        private string name;

        private string id;

        private int year;

        public Student(string name,string id, int year)
        {
            this.name = name;
            this.id = id;
            this.year = year;
         
        }

        public void Print()
        {
            Console.WriteLine(name + " " + id + " " + year);
        }
        public void Increment()
        {
            this.year = this.year + 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = "Niyazbi";
            string id = "18BD113399";
            int year = 2019;

            Student s2 = new Student(name, id, year);
            
            s2.Increment();
            s2.Print();
            Console.ReadLine();
        }
    }
}
