using System;
using System.Linq;
using System.Collections.Generic;

namespace KataTasks
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public string mazeRunner(int[,] maze, string[] directions)
        {
            int y = 0;
            int x = 0;
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    if (maze[i, j] == 2)
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == "N") y--;
                if (directions[i] == "S") y++;
                if (directions[i] == "W") x--;
                if (directions[i] == "E") x++;

                if (x == maze.GetLength(0)) return "Dead";
                if (y == maze.GetLength(1)) return "Dead";

                if (maze[x, y] == 1) return "Dead";
                if (maze[x, y] == 3) return "Finish";
            }
            return "Lost";
        }


        public static string[] dirReduc(String[] arr)
        {
            int NORTH = 0;
            int SOUTH = 0;
            int EAST = 0;
            int WEST = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "NORTH") NORTH++;
                else if (arr[i] == "SOUTH") SOUTH++;
                else if (arr[i] == "WEST") WEST++;
                else if (arr[i] == "EAST") EAST++;
            }
            if (NORTH >= SOUTH)
            {
                NORTH = NORTH - SOUTH;
                SOUTH = 0;
            }
            else
            {
                SOUTH = SOUTH - NORTH;
                NORTH = 0;
            }
            if (EAST >= WEST)
            {
                EAST = EAST - WEST;
                EAST = 0;
            }
            else
            {
                WEST = WEST - EAST;
                EAST = 0;
            }
            string[] ans = new string[NORTH + SOUTH + EAST + WEST];
            int j = 0;
            for (; j < NORTH; j++)
            {
                ans[j] = "NORTH";
            }
            for (; j < NORTH + EAST; j++)
            {
                ans[j] = "EAST";
            }
            for (; j < NORTH + EAST + SOUTH; j++)
            {
                ans[j] = "SOUTH";
            }
            for (; j < NORTH + EAST + SOUTH + WEST; j++)
            {
                ans[j] = "WEST";
            }
            return ans;

        }
        public static bool Narcissistic(int value)
        {
            string num = Convert.ToString(value);
            int l = num.Length;
            int ans = 0;
            for (int i = 0; i < l; i++)
            {
                int bns = 1;
                for (int j = 0; j < l; j++)
                {
                    bns = bns * Convert.ToInt32(num[i] - 48);
                }
                ans = ans + bns;
            }
            if (ans == value) return true;
            else return false;
        }

        public static int Test(string numbers)
        {
            int[] q = numbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int a = 0;
            int b = 0;
            int aa = 0;
            int bb = 0;
            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] % 2 == 1)
                {
                    a++;
                    aa = i;
                }
                else
                {
                    b++;
                    bb = i;
                }
            }
            return (a == 1 ? aa : bb) + 1;
            


        }
                public static string Likes(string[] name)
        {
            if (name.Length == 0) return "no one likes this";
            if (name.Length == 1) return name[0] + " likes this";
            if (name.Length == 2) return name[0] + " and " + name[1] + " like this";
            if (name.Length == 3) return name[0] + ", " + name[1] + " and " + name[2] + " like this";
            if (name.Length > 3) return name[0] + ", " + name[1] + " and " + (name.Length - 2) + " others like this";
            return "no one likes this";
        }

                public static string PigIt(string str)
        {
            string ans = "";
            string[] words = str.Split(' ');
            for(int i=0;i<words.Length;i++)
            {
                ans = ans + words[i].Remove(0, 1) + words[i][0] + "ay ";
            }
            ans = ans.Remove(ans.Length - 1, 1);
            return ans;
        }
    }
}
