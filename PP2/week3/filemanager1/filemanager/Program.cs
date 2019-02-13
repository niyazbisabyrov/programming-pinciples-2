using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filemanager
{
    enum FSIMode
    {
        Directory = 0,
        File = 1,
        Zip = 2
    }

    class Program
    {

        static void Main(string[] args)
        {

            int mode;
            mode = Convert.ToInt32(Console.ReadLine());
            int mode2 = 2;
            //0 - dir
            //1 - file
            //2 - zip
            //..
            if (mode2 == 0)
            {
                Console.WriteLine("DIR!");
            }
            else if (mode2 == 1)
            {
                Console.WriteLine("FILE!");
            }
            else if (mode2 == 2)
            {
                Console.WriteLine("ZIP!");
            }
            if (mode == FSIMode.Directory)
            {
                Console.WriteLine("Directory");
            }
            else if(mode == FSIMode.File)
            {
                Console.WriteLine("file");

            }
            else if(mode == FSIMode.Zip)
            {
                Console.WriteLine("Zip");
            }
        }
    }
}
