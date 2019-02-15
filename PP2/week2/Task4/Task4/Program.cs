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
            
            File.WriteAllText(@"C: \Users\Lenovo\source\repos\PP2\week2\Task4\Task4\\createdfile.txt", "abcd");
            string content = File.ReadAllText(@"C: \Users\Lenovo\source\repos\PP2\week2\Task4\Task4\\createdfile.txt");
            File.WriteAllText(@"C: \Users\Lenovo\source\repos\PP2\week2\Task4\Task4\\newfile.txt" , "");
            File.AppendAllText(@"C: \Users\Lenovo\source\repos\PP2\week2\Task4\Task4\\newfile.txt", content);
            File.Delete(@"C: \Users\Lenovo\source\repos\PP2\week2\Task4\Task4\\createdfile.txt");





        }
    }
}
