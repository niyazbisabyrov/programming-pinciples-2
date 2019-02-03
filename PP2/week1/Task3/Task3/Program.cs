using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] a = Console.ReadLine().Split();
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i]);
                Console.Write(" ");
                Console.Write(a[i]);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}
