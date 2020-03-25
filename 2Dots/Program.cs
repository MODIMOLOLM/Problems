using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Dots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x parameter of A dot");
            int xa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y parameter of A dot");
            int ya = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter x parameter of B dot");
            int xb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y parameter of B dot");
            int yb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter x parameter of C dot");
            int xc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y parameter of C dot");
            int yc = Convert.ToInt32(Console.ReadLine());

            float ab = (xa - xb) * (xa - xb) + (ya - yb) * (ya - yb);
            float ac = (xa - xc) * (xa - xc) + (ya - yc) * (ya - yc);
            float bc = (xb - xc) * (xb - xc) + (yb - yc) * (yb - yc);
            if (ab < bc && ab < ac) Console.WriteLine("A and B are the shortest dots");
            if (bc < ab && bc < ac) Console.WriteLine("B and C are the shortest dots");
            if (ac < ab && ac < bc) Console.WriteLine("A and C are the shortest dots");

        }
    }
}
