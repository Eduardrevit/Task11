using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
         
            Linur linur = new Linur(k, b);
            Console.WriteLine(linur.Root());
            Console.ReadKey();
        }
    }
}
