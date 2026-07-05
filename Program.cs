using System;

namespace Hello
{
    public class Program
    {
        public static void Main()
        {
            GreetEveryone();
            GreetWhite();
            GreetBlack();
        }

        public static void GreetEveryone()
        {
            Console.WriteLine("hello everyone");
        }

        public static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }

        public static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }
    }
}