﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
                if (action.Equals("EXIT")) { furtherOn = false; }
                else
                {
                    try
                    {
                        Console.WriteLine(romanToArabicLogic.RomanToArabic(action));
                    }
                    catch (ArgumentException) { Console.WriteLine("The Roman numberal cannot be converted. Please enter only valid Letters\n\t => M, D, C, X, V, I"); }
                }
            } while (furtherOn);
        }
    }
}
