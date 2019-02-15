using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.IO;

namespace Task2

{

    class Kilogram

    {

        static bool isPrime(int x)
        {

            if (x < 2)

                return false;

            for (int i = 2; i <= Math.Sqrt(x); ++i)

                if (x % i == 0)

                    return false;

            return true;//простая функция для простых чисел

        }

        static void Main(string[] args)

        {

           
            using (StreamWriter file1 = new StreamWriter(@"C:\Users\Lenovo\source\repos\PP2\Week2\Task2\Task2\input1.txt"))
               File.Create(@"C:\Users\Lenovo\source\repos\PP2\Week2\Task2\Task2\input1.txt"\\)
            using (StreamWriter file = new StreamWriter(@"C:\Users\Lenovo\source\repos\PP2\Week2\Task2\Task2\output.txt"))//путь к созданному файлу
            {

                foreach (string number in text)

                {
                    
                    int x = Convert.ToInt32(number);

                    if (isPrime(x))

                        file.Write(number + " ");//если число из инпута простой то его записываем в аутпут вместе с пробелом
                    
                }
                file1.delete();
            }

        }

    }

}