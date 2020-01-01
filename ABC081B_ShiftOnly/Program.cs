using System;
using System.Linq;
namespace ABC081B_ShiftOnly
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] inp = Console.ReadLine().Split(' ').Select<string, int>(e => int.Parse(e)).ToArray();
            int cnt = 0;
            bool flag = true;
            while (flag)
            {
                if(inp.Any(e => e%2 != 0))
                {
                    break;
                }
                inp = inp.Select(e => e / 2).ToArray();

                cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}
