using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC085B_KagamiMochi
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> d = new List<int>();
            for (int i = 0; i < n; i++)
            {
                d.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(d.Distinct().Count());

        }
    }
}
