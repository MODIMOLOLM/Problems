using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot(942));
        }

          static public int DigitalRoot(int n)
          {
            return 1 + (n - 1) % 9;
          }
    }
}
