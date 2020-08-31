using System;

namespace CodeWars.RemoveFirstAndLastCharacter
{
    public class Program
    {
        public static string Remove_char(string s)
        {
            return s.Substring(1, s.Length - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
