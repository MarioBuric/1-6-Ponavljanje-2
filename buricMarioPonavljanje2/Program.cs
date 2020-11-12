using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buricMarioPonavljanje2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi niz znakova");
            string s1 = Console.ReadLine();
            s1 = s1.Replace(" ", "_");
            
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}


