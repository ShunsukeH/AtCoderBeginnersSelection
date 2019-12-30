using System;
namespace ABC086A_Product
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            Console.WriteLine((a * b) % 2 == 0 ? "Even" : "Odd");
        }
    }
}
