using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = int.Parse(Console.ReadLine()) ;//val - для того чтобы прописать в консоле размер треугольника
            int i, j, k;//i and j  мы используем для двухмерного массива
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)//val - 1 для того чтобы вывести треуголник слевой стороны чтобы j был меньше i
                {
                     
                }
                for (k = 1; k <= i; k++)//k у нас массив из подходящих мест для звездочки
                {
                    Console.Write("[*]");
                }
                Console.WriteLine("");//чтобы в остольных местах были пробелы
            }
            Console.ReadLine();// чтобы консоле после вводов не закрывался
        }
    }
}
