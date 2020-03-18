

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot(942));
        }

          static public int DigitalRoot(long n)
          {
            long ans=0;
            string q=Convert.ToString(n);
            while(q.Length !=1)
            {
                ans=0;
                for(int i=0;i<q.Length;i++)
                    {
                ans=ans+q[i]-48;
                }
                q=Convert.ToString(ans);
                Console.WriteLine(ans);
            }
            return Convert.ToInt32(ans);

          }
    }
}
