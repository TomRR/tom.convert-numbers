using System;
using System.Collections.Generic;
using System.Text;

namespace Tom.ConvertNumbers
{
    class RomanMenu : IMenu
    {
        ConvertingLogic romanToArabicLogic = new ConvertingLogic();
        public void EnterMenu()
        {
            bool furtherOn = true;
            do
            {
                string action;
                Console.Write("\nEnter your Roman Digit to convert or type Exit to go back\n\t-->");
                action = Console.ReadLine().ToUpper();
                if (action.Equals("")) { Console.WriteLine("Nochmal"); }
                if (action.Equals("EXIT")) { furtherOn = false; }
                Console.WriteLine(romanToArabicLogic.RomanToArabic(action));

            } while (furtherOn);
        }
    }
}
