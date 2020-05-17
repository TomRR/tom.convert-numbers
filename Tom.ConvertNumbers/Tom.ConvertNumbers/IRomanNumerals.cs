using System;
using System.Collections.Generic;
using System.Text;

namespace Tom.ConvertNumbers
{
    interface IRomanNumerals
    {
        /// <summary>
        /// Convert an arabic number to a roman numeral
        /// </summary>
        /// <param name="arabic"></param>
        /// <returns>the roman number or null, if the number is not valid.</returns>
        string ArabicToRoman(int arabic);

        /// <summary>
        /// Convert a roman numeral to an arabic number
        /// </summary>
        /// <param name="roman"></param>
        /// <returns>the arabic number or -1, if the number is not valid.</returns>
        int RomanToArabic(string roman);
    }
}
