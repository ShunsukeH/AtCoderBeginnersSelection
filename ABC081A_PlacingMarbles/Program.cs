using System;
using System.Linq;
namespace ABC081A_PlacingMarbles
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.ToCharArray().Where(e => e == '1').Count());
        }
    }
}
