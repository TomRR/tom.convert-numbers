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
                string action;
                Console.Write("\nEnter your Arabic Digit between 1 and 3999 to convert or type Exit to go back\n\t-->");
                action = Console.ReadLine().ToUpper();
                if (action.Equals("EXIT")) { furtherOn = false; }
                if (Int32.Parse(action) == 0) { Console.WriteLine("some sources claim the Romans had no representation for zero, they used the word 'Nulla'."); }
                else
                {
                    try
                    {
                        if (Int32.Parse(action) < 0 || Int32.Parse(action) > 3999)
                        {
                            Console.WriteLine("The number cannot be converted. Please enter a number between 1 and 3999.");
                        }
                        else
                        {
                            Console.WriteLine(arabicToRomanLogic.ArabicToRoman(Int32.Parse(action)));
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("This are Letters not arabic Digits. Please enter a number between 1 and 3999.");
                    }
                }
            } while (furtherOn);
        }
    }
}
