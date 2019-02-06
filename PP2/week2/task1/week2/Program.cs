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

            string text = File.ReadAllText(@"C:\Users\Lenovo\source\repos\PP2\week2\task1\week2\niyazbi.txt");
            text = text.TrimEnd();
            char[] txet = text.ToCharArray();
          
            Array.Reverse(txet);
            
            string s = new string(txet);
            if (s == text)

                Console.WriteLine("YES");

            else if(s != text)
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
        
    }

}