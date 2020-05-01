using System;

namespace Tom.ConvertNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConvertingLogic number = new ConvertingLogic();

            string result = number.ArabicToRoman(1059);
            Console.WriteLine("Arabic to Roman " + result);
        }
    }
}
