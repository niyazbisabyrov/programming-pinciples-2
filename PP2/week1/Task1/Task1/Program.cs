using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static bool isPrime(int x)
        {
            // мы используем булевую функцию чтобы вывести простые числа
            for (int i = 2; i * i == x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            string s = "";
            string[] arr = Console.ReadLine().Split();//Split()- разбивает строку в массиве на подстроки в зависимости символов.
            for (int i = 0; i < n; i++)
            {
                int x; // мы добовляем x Н-ный раз
                x = int.Parse(arr[i]);
                if (isPrime(x) && x > 1) // проверяем х с помощью функции 
                {
                    s = s + x; // если х у нас простое число то мы ее добовляем к строке s чтобы вывести количество простых чисел
                }
            }
            Console.WriteLine(s.Length); // чтобы прописать в консоле кол-во простых чисел 
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]); // чтобы прописать в консоле каждый простое число
                Console.Write(" "); // чтобы написать слитно простые числа
            }


        }
    }
}