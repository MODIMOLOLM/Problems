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
            Console.WriteLine(StrSplit("one two three omgog lol funny",' '));
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
        public static string[] StrSplit(string full, char c)
        {
            int q=1;
            for(int i=0;i<full.Length;i++)
            {
                if(full[i]==c)
                {
                    q++;
                }
            }
            string[] ans=new string[q];
            int t=0;
            int u=0;
            string s =full;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]==c)
                {
                    ans[t]=s.Remove(0,u);
                    t++;
                    Console.WriteLine(s.Remove(0,u));
                    s.Remove(0,u);
                    u=i;
                }
            }
            return ans;
        }

        public static string StrJoin(string[] full)
        {
            string ans="";
            for(int i=0;i<full.Length;i++)
            {
                ans=ans+full[i];
            }
            return ans.Remove(ans.Length-1);
        }
    }
}
