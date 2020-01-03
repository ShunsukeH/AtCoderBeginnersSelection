using System;
using System.Linq;

namespace ABC088B_CardGameForTwo
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] cards = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(cards);
            Array.Reverse(cards);

            int aliceTotal = 0;
            int bobTotal = 0;
            for (int i = 0; i < n; i++)
            {
                if (i%2 == 0)
                {
                    aliceTotal += cards[i];
                }
                else
                {
                    bobTotal += cards[i];
                }
            }
            Console.WriteLine(aliceTotal - bobTotal);
        }
    }
}
