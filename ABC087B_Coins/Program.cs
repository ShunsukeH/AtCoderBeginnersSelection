using System;
namespace ABC087B_Coins
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int cnt  = 0;
            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j <= b; j++)
                {
                    for (int k = 0; k <= c; k++)
                    {
                        if(500*i + 100*j + 50*k == x)
                        {
                            cnt++;
                        }
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
