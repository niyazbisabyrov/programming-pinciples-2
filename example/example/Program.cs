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
        dir,//папка
        file//файл
    }

    class Layer
    {
        public FileSystemInfo[] Content
        {
            get;//возвращаем занчение
            set;//устанавливаем
        }
        public int SelectedItem//курсор
        {
            get;
            set;
        }
        public void Draw()//функция которая отвечает за цветовую гамму
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            if (ViewMode.dir == ViewMode.dir)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }


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
            bool esc = false;
            while (!esc)
            {
                if (ViewMode == ViewMode.dir)
                {
                    history.Peek().Draw();
                }
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (history.Peek().SelectedItem > 0)
                            history.Peek().SelectedItem--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (history.Peek().Content.Length - 1 > history.Peek().SelectedItem)
                            history.Peek().SelectedItem++;
                        break;
                    case ConsoleKey.Escape:
                        esc = true;
                        break;



                }
            }

        }

    }
}