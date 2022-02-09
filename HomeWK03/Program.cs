using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWK03_lib;
namespace HomeWK03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Randomizers Randomize = new Randomizers();

            IntList List1 = new IntList();
            Console.WriteLine(List1.PrintAll() + $"\t{List1.Size}");
            Randomize.IntRnd(List1, 10);
            Console.WriteLine(List1.PrintAll() + $"\t{List1.Size}");
            List1.RemoveAt(5);
            List1.RemoveAt(4);
            Console.WriteLine(List1.PrintAll() + $"\t{List1.Size}");
            Console.ReadLine();
            Console.Clear();

            StrList List2 = new StrList();
            Console.WriteLine(List2.PrintAll() + "\t" + List2.Size);
            Randomize.StrRnd(List2, 10, 3);
            Console.WriteLine(List2.PrintAll() + "\t" + List2.Size);
            List2.RemoveAt(5);
            Console.WriteLine(List2.PrintAll() + "\t" + List2.Size);
            Console.ReadLine();
            Console.Clear();



        }
    }
}
