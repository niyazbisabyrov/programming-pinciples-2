using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
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
            get;
            set;
        }
        public int SelectedItem
        {
            get;
            set;
        }
        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();                                //заднии фон черный
            
            for(int i = 0; i < Content.Length; i++)
            {
                if(i == SelectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;//задний фон на котором стоит курсор  синий

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;//а в других черный
                }
                Console.WriteLine(Content[i].Name);
               
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Lenovo\source\repos");//папка в консоле
            Stack<Layer> history = new Stack<Layer>();
            history.Push(
                new Layer
                {
                    Content = directory.GetFileSystemInfos()
                });

           

            ViewMode ViewMode =  ViewMode.dir;
            bool esc = false;
            while (!esc)
            {
                if(ViewMode == ViewMode.dir)
                {
                    history.Peek().Draw();
                }
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (history.Peek().SelectedItem > 0)
                            history.Peek().SelectedItem--;//чтобыидти с курсором вверх
                        break;
                    case ConsoleKey.DownArrow:
                        if (history.Peek().Content.Length - 1 > history.Peek().SelectedItem)
                            history.Peek().SelectedItem++;//что бы идти с куросром вниз
                        break;
                    case ConsoleKey.Escape:
                        esc = true;//при нажатии екс то закрывается консоль

                        break; 
                        
                }
                    

            }
        }
    }
}
