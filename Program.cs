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
            var myArray = s.ConvertToByteArray();
            foreach (var caracter in myArray)
            {
                Console.Write(caracter + "-");
            }
            Console.WriteLine();
            
            var theClass = new MyClass();
            Console.WriteLine(theClass.GetNumberWithCurrency("$"));
        }
    }

    public static class MyExtensions 
    {
        public static int GetWordCount(this String str)
        {
            var arrayWords = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return arrayWords.Length -1;
        }

        public static byte[] ConvertToByteArray(this String str)
        {
            return System.Text.Encoding.UTF8.GetBytes(str);
        }

        
    }
}
