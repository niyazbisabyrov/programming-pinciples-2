using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filemanager1
{
    enum ViewMode
    {
        dir,
        file
    }

    class Layer
    {
        public FileSystemInfo[] Content
        {
            get;//возвращаем занчение
            set;//устанавливаем
        }
        public int SelectedItem
        {
            get;
            set;
        }
        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            for (int i = 0; i < Content.Length; ++i)
            {
                if (i == SelectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(Content[i].Name);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Lenovo\source\repos");
            Stack<Layer> history = new Stack<Layer>();
            history.Push(
                new Layer
                {
                    Content = dir.GetFileSystemInfos()
                }
                );
            ViewMode ViewMode = ViewMode.dir;
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

        }
    }
}