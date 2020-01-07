using System;

namespace ABC086C_Traveling
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] t = new int[110000];
            int[] x = new int[110000];
            int[] y = new int[110000];
            t[0] = x[0] = y[0] = 0;
            
            for (int i = 1; i <= n; i++)
            {
                string[] inp = Console.ReadLine().Split(' ');
                t[i] = int.Parse(inp[0]);
                x[i] = int.Parse(inp[1]);
                y[i] = int.Parse(inp[2]);
            }

            bool result = true;
            for (int i = 0; i < n; i++)
            {
                int dt = t[i + 1] - t[i];
                int dist = Math.Abs(x[i + 1] - x[i]) + Math.Abs(y[i + 1] - y[i]);
                if (dt - dist < 0 || (dt - dist) % 2 != 0)
                {
                    result = false;
                    break;
                }
            }
            Console.WriteLine(result ? "YES" : "NO");
        }
    }
}
