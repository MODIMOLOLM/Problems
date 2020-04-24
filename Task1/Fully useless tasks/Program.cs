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
            string[] a = StrSplit("one two three omgog lol funny two", ' ');
            Console.WriteLine(StrJoin(a));
        }
        public static bool IsSubString(string full, string sub)
        {
            int q = 0;
            for(int i=0;i-1<full.Length-sub.Length;i++)
            {
                for (int j = 0; j < sub.Length; j++) 
                {
                    if (full[i + j] == sub[j]) q++;
                    else break;
                }
                if (q >= sub.Length) return true;
                q = 0;
            }
            return false;
        }

        public static int[] FindSubstr(string full, string sub)
        {
            List<int> ans = new List<int>();
            int q = 0;
            for(int i=0;i-1<full.Length-sub.Length;i++)
            {
                
                for (int j = 0; j < sub.Length; j++) 
                {
                    if (full[i + j] == sub[j]) q++;
                    else break;
                }
                if (q >= sub.Length)
                {                             
                ans.Add(i);
                }
                q = 0;
            }
            return ans.ToArray();
        }
        public static string[] StrSplit(string full, char c)
        {
            int start = 0;
            int finish = 0;
            List<string> ans = new List<string>();
            for(int i=0;i<full.Length;i++)
            {
                if(full[i]==c)
                {
                    finish = i;
                    ans.Add(full.Substring(start, finish-start));
                    start = finish+1;
                }
            }
            return ans.ToArray();
        }

        public static string StrJoin(string[] full)
        {
            StringBuilder ans=new StringBuilder();
            for(int i=0;i<full.Length;i++)
            {
                ans.Append(full[i]);
                ans.Append(" ");
            }
            ans.Remove(ans.Length - 1,1);
            return ans.ToString();
        }
    }
}
