using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BigIntsTrainig
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = long.MaxValue;
            BigInteger b = long.MaxValue;
            Console.WriteLine("* " + (a * b));
            Console.WriteLine("/ " + (a / b));
            Console.WriteLine("+ " + (a + b));
            Console.WriteLine("- " + (a - b));
        }
    }
}
