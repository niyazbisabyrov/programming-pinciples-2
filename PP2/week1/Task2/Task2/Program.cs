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

        private string id;//конструктор с двумя пораметрами(имя и айди)

        private int year;//инкрементируем 

        public Student(string name,string id, int year)
        {
            this.name = name;
            this.id = id;
            this.year = year;
         
        }

        public void Print()//чтобы вывести данные
        {
            Console.WriteLine(name + " " + id + " " + year);
        }
        public void Increment()//прибавить 1 к году
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
            int year = 2019;//данные имя айди и год

            Student s2 = new Student(name, id, year);
            
            s2.Increment();//выполнить функцию чтобы прибавить 1 на заданный год
            s2.Print();//выполнить функицю чтобы вывести на консол
            Console.ReadLine();//чтобы закрывать консоль после нажатия на клавиатуру
        }
    }
}
