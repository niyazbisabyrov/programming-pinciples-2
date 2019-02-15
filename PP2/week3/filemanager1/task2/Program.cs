using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filemanager1
{
    enum ViewMode {
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
            
               
             for(int i = 0; i <Content.Length; ++i)
            {
                if(i == SelectedItem)
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
            while(!esc)
            {if (ViewMode == ViewMode.dir)
                {
                    history.Peek().Draw();
                }
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {

                    case ConsoleKey.Delete:
                        int x2 = history.Peek().SelectedItem;
                        FileSystemInfo fileSystemInfo2 = history.Peek().Content[x2];
                        history.Peek().SelectedItem--;
                        if (fileSystemInfo2.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo directoryInfo = fileSystemInfo2 as DirectoryInfo;
                            Directory.Delete(fileSystemInfo2.FullName, true);
                            history.Peek().Content = directoryInfo.Parent.GetFileSystemInfos();
                        }
                        else
                        {
                            FileInfo fileInfo = fileSystemInfo2 as FileInfo;
                            File.Delete(fileSystemInfo2.FullName);
                            history.Peek().Content = fileInfo.Directory.GetFileSystemInfos();
                        }

                        break;






                    case ConsoleKey.UpArrow:
                        if (history.Peek().SelectedItem - 1 < 0)
                        {



                            history.Peek().SelectedItem = history.Peek().Content.Length -1;
                        }
                        else history.Peek().SelectedItem--;
                        
                        break;










                    case ConsoleKey.DownArrow:
                        if (history.Peek().Content.Length  - 1 <= history.Peek().SelectedItem)
                        {
                            history.Peek().SelectedItem = 0;
                        }

                            else history.Peek().SelectedItem++;
                        break;










                    case ConsoleKey.Enter:
                int x = history.Peek().SelectedItem;
                        FileSystemInfo fileSystemInfo = history.Peek().Content[x];

                        if (fileSystemInfo.GetType() == typeof(DirectoryInfo)){
                            ViewMode = ViewMode.dir;
                            DirectoryInfo selecteddir = fileSystemInfo as DirectoryInfo;
                            history.Push(new Layer { Content = selecteddir.GetFileSystemInfos() });
                        }
                        else
                        {
                            ViewMode = ViewMode.file;
                            using (FileStream fs = new FileStream(fileSystemInfo.FullName, FileMode.Open, FileAccess.Read))
                            {
                                using (StreamReader sr = new StreamReader(fs))
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine(sr.ReadToEnd());
                                }
                            }
                        }
                        break;
                    case ConsoleKey.Backspace:
                        if (ViewMode == ViewMode.dir)
                        {
                            history.Pop();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            ViewMode = ViewMode.dir;
                        }
                        break;
                    
                    case ConsoleKey.Escape:
                        esc = true;
                        break;
                    

                       
                }
                }
                    
            }
        
        }
    }

