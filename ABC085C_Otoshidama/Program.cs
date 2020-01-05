using System;
namespace ABC085C_Otoshidama
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string[] inp = Console.ReadLine().Split(' ');
            int n = int.Parse(inp[0]);
            int y = int.Parse(inp[1]);

            bool flag = false;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n - i; j++)
                {
                    int k = n - (i + j);
                    if (10000 * i + 5000 * j + 1000 * k == y)
                    {
                        flag = true;
                        Console.WriteLine($"{i} {j} {k}");
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("-1 -1 -1");
            }
        }
    }
}
