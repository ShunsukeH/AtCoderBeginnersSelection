using System;
using System.Linq;

namespace ABC049C_Daydream
{
    class MainClass
    {
        private static string[] dic = { "dream", "dreamer", "erase", "eraser" };

        static void Main()
        {
            string inp = Console.ReadLine();
            inp = new string(inp.Reverse().ToArray());
            while (true)
            {
               string sub = dic.Select(e => new String(e.Reverse().ToArray())).FirstOrDefault(e => inp.StartsWith(e));
                if (String.IsNullOrEmpty(sub))
                {
                    break;
                }
                inp = inp.Remove(0, sub.Length);
            }
            Console.WriteLine(inp.Length == 0 ? "YES" : "NO");
        }
    }
}
