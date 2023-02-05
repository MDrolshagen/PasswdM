using System;

namespace PasswdM // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }

        static void Start()
        {
            Console.WriteLine("PaswdM");
            Console.WriteLine("==========================");
            Console.Write(">> Profile: ");
            string profile = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Selected Profile: [" + profile + "]");

        }
    }
}