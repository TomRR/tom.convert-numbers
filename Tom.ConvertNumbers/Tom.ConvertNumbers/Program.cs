using System;

namespace Tom.ConvertNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu arabicMenu = new Menu();
            Menu romanMenu = new Menu();
            arabicMenu.SetMenu(new ArabicMenu());
            romanMenu.SetMenu(new RomanMenu());

            bool furtherOn = true;
            do
            {
                string action;
                Console.Write("\nChoose an action \n\tArabic digit to Roman digit (a)\n\tRoman digit to Arabic digit (r)\n\tExit (x)\n\t-->");
                action = Console.ReadLine();
                switch (action)
                {
                    case "a":
                        arabicMenu.EnterMenu();
                        break;
                    case "r":
                        romanMenu.EnterMenu();
                        break;
                    case "x":
                        furtherOn = false;
                        break;
                    default:
                        Console.WriteLine("that was not correct. please choose from the listed options");
                        break;
                }
            } while (furtherOn);
        }
    }
}
