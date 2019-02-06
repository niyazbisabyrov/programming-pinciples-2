using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.IO;



namespace Task1

{

    class Program

    {

        static void Main(string[] args)

        {

            string text = File.ReadAllText(@"C:\Users\Lenovo\source\repos\ConsoleApp7\ConsoleApp7\input.txt");

            char[] txet = text.ToCharArray();

            Array.Reverse(txet);

            string s = new string(txet);

            if (s == text)

                Console.WriteLine("YES");

            else

                Console.WriteLine("NO");

        }

    }

}