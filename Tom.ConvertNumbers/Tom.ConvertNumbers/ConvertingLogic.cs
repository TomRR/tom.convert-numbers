using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Tom.ConvertNumbers
{
    public class ConvertingLogic : IRomanNumerals
    {
        public string ArabicToRoman(int arabic)
        {
			StringBuilder romanDigitStringBuilder = new StringBuilder();
			foreach (var romanNumeral in Enum.GetValues(typeof(RomanNumeral)).Cast<RomanNumeral>().Reverse())
			{
				while (arabic >= (int)romanNumeral)
				{
					arabic -= (int)romanNumeral;
					romanDigitStringBuilder.Append(romanNumeral);
				}
			}
			return romanDigitStringBuilder.ToString();

		}

		public int RomanToArabic(string roman)
		{

			String romanNumeral = roman.ToUpper();
			if (roman == "NULLA") return 0;

			int i = 0;
			ArrayList values = new ArrayList();
			int maxDigit = 1000;
			while (i < roman.Length)
			{
				char numeral = roman[i];
				int digit = (int)Enum.Parse(typeof(RomanNumeral), numeral.ToString());

				int nextDigit = 0;
				if (i < roman.Length - 1)
				{
					char nextNumeral = roman[i + 1];
					nextDigit = (int)Enum.Parse(typeof(RomanNumeral), nextNumeral.ToString());

					if (nextDigit > digit)
					{
						maxDigit = digit - 1;
						digit = nextDigit - digit;
						i++;
					}
				}

				values.Add(digit);
				i++;
			}

			int total = 0;
			foreach (int digit in values)
			{
				total += digit;
			}			
			return total;
		}
	}
}
