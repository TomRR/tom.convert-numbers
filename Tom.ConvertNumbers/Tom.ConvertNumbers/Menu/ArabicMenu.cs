using System;
using System.Collections.Generic;
using System.Text;

namespace Tom.ConvertNumbers
{
    class ArabicMenu : IMenu
    {
        ConvertingLogic arabicToRomanLogic = new ConvertingLogic();
        public void EnterMenu()
        {
            bool furtherOn = true;
            do
            {
                int action;
                Console.Write("\nEnter your Arabic Digit to convert or type Exit to go back\n\t-->");
                action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 0:
                        furtherOn = false;
                        break;
                    default:
                        Console.WriteLine(arabicToRomanLogic.ArabicToRoman(action));
                        break;
                }
            } while (furtherOn);
        }
    }
}
