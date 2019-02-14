using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Lenovo\source\repos\PP2\week2\Task4\Task4\delete.txt";//файл которую нам придется удалить

            string path1 = @"C:\Users\Lenovo\source\repos\PP2\week2\Task4\Task4";//путь куда будем сохранять дубликат файла

            DirectoryInfo dirInfo = new DirectoryInfo(path1);//directoryinfo - для создания, перемещения в каталогах

            FileInfo fi = new FileInfo(path);//fileinfo используется для удаления копирования

            if (fi.Exists && dirInfo.Exists)//если все скапировано и файлы существуют в заданном пути

            {

                fi.CopyTo(path1 + @"\Copied.txt", true);//создаем новый дубликат в паз1

                fi.Delete();//удаляем паз

            }

            else Console.WriteLine("path or path1 not found");//если нету файла в заданном пути
        }
    }
}
