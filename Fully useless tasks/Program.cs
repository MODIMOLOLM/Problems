using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fully_useless_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSubString("simp lol haha stinkssz","sdfgl"));
        }
        public static bool IsSubString(string full, string sub)
        {
            int q = 0;
            for(int i=0;0<full.Length-sub.Length;i++)
            {
                for (int j = 0; j < sub.Length; j++) 
                {
                    if (full[i + j] == sub[j]) q++;
                }
                if (q == sub.Length) return true;
                q = 0;
            }
            return false;
        }
    }
}
