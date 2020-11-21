using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "Hello World! my friends.";
            Console.WriteLine(s);
            Console.WriteLine(s.GetWordCount());
        }
    }

    public static class MyExtensions 
    {
        public static int GetWordCount(this String str)
        {
            var arrayWords = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return arrayWords.Length;
        }
    }
}
