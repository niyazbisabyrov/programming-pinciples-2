using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {


        static void Main(string[] args)
        {
            int num1;
            int num2;
            
            
            Console.WriteLine();
            num1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("\n");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(num1 + num2);
            Console.ReadKey();
        }
    }
}