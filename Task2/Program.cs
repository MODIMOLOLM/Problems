using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;
            int min3 = int.MaxValue;

            int j;
            int[] a = { 1,5,4,2, 1, 5, 4, 2 , 4, 31, 1, 1};

            for (int i=0;i<a.Length;i++)
            {
                if (max < a[i]) max = a[i];
            }
            Console.WriteLine("Последний минимальный элемент в массиве: "+max);

            for (int i = 0; i < a.Length; i++)
            {
                if (min1 > a[i]) min1 = a[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (min2 > a[i]&&min1 !=a[i]) min2 = a[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (min3 > a[i] && min1 != a[i] && min2 != a[i]) min3 = a[i];
            }

            Console.WriteLine("1 " + min1);
            Console.WriteLine("2 " + min2);
            Console.WriteLine("3 " + min3);

            min1 = int.MaxValue;
            min2 = int.MaxValue;
            min3 = int.MaxValue;

            int min = int.MaxValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (min1 > a[i])
                {
                    min1 = i;
                    min = a[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (min2 > a[i] && min1 != i) min2 =i;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (min2 > a[i] && min1 != i && min2 != i) min3=i;
            }


            Console.WriteLine();
            Console.WriteLine("1 " + min1);
            Console.WriteLine("2 " + min2);
            Console.WriteLine("3 " + min3);
            Console.WriteLine("min = " + min);


        }
    }
}
