using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static bool IsPangram(string str)
        {
            string str1=str.ToLower();
            int a = 0;
            char[] alphabet = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (str1[i] == alphabet[j])
                    {
                        a++;
                        alphabet[j] = '0';
                    }
                }
            }
            if (a == 26) return true;
            else return false;
        }

    }
}
