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
                for (int j = 0; j <= n-i; j++)
                {
                    for (int k = 0; k <= n-i-j; k++)
                    {
                        //Console.WriteLine($"{i} {j} {k}");
                        if (10000 * i + 5000 * j + 1000 * k == y && i+j+k == n)
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
