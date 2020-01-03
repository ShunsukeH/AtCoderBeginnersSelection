using System;
namespace ABC083B_SomeSums
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int a = int.Parse(str[1]);
            int b = int.Parse(str[2]);

            int total = 0;

            for (int i = 1; i <= n; i++)
            {
                int p = i;
                int q = p % 10;
                while (p >= 10)
                {
                    p /= 10;
                    q += p % 10;
                }
                if (a <= q && q <= b)
                {
                    total += i;
                }
            }
            Console.WriteLine(total);

        }
    }
}
