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
            Console.WriteLine( FindSubstr("baaa","aa") );
        }
        public static bool IsSubString(string full, string sub)
        {
            int q = 0;
            for(int i=0;i-1<full.Length-sub.Length;i++)
            {
                for (int j = 0; j < sub.Length; j++) 
                {
                    if (full[i + j] == sub[j]) q++;
                }
                if (q >= sub.Length) return true;
                q = 0;
            }
            return false;
        }

        public static string FindSubstr(string full, string sub)
        {
            int q = 0;
            for(int i=0;i-1<full.Length-sub.Length;i++)
            {
                for (int j = 0; j < sub.Length; j++) 
                {
                    if (full[i + j] == sub[j]) q++;
                }
                if (q >= sub.Length)
                {                             
                Console.WriteLine(i+1);
                }
                q = 0;
            }
            return "";
        }
    }
}
