using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tom.ConvertNumbers
{
    public class ConvertingLogic : IRomanNumerals
    {
        public string ArabicToRoman(int arabic)
        {
			StringBuilder romanDigit = new StringBuilder();

			foreach (var romanNumeral in Enum.GetValues(typeof(RomanNumeral)).Cast<RomanNumeral>().Reverse())
			{
				bool startsWith4 = arabic.ToString().StartsWith("4");
				bool startsWith9 = arabic.ToString().StartsWith("9");
				if(startsWith4 || startsWith9)
				{

				} 
				else
				{
					while (arabic >= (int)romanNumeral)
					{
						arabic -= (int)romanNumeral;
						romanDigit.Append(romanNumeral);
					}
				}
 
			}
			
			return romanDigit.ToString();
		}

        public int RomanToArabic(string roman)
        {
			//roman = roman.ToUpper().Trim();

			//var values = Enum.GetValues(typeof(RomanNumeral));
			//for (int i = values.Length; i-- > 0;)
			//{
			//	Console.Write((int)values.GetValue(i) + " ? ");
			//}
			//foreach(var romanNumeral in Enum.GetValues(typeof(RomanNumeral)).Cast<RomanNumeral>().Reverse())
			//{
			//	if(roman <= (int)romanNumeral)
			//	{

			//	}
			//	Console.WriteLine(romanNumeral + ": " + (int)romanNumeral);
			//}

			int result = 0;
			string[] romanChar = System.Text.RegularExpressions.Regex.Split(roman, "");
			var c = RomanNumeral.C;
			int Cletter = (int)RomanNumeral.C;
			Console.WriteLine(c);
			Console.WriteLine(Cletter);
			foreach (string ci in romanChar)
			{
				result += 1;
			}



			//int ptr = 0;
			//ArrayList values = new ArrayList();
			//int maxDigit = 1000;
			//while (ptr < roman.Length)
			//{
			//	char numeral = roman[ptr];
			//	int digit = (int)Enum.Parse(typeof(Umrechnung), numeral.ToString());

			//	int nextDigit = 0;
			//	if (ptr < roman.Length - 1)
			//	{
			//		char nextNumeral = roman[ptr + 1];
			//		nextDigit = (int)Enum.Parse(typeof(Umrechnung), nextNumeral.ToString());

			//		if (nextDigit > digit)
			//		{
			//			maxDigit = digit - 1;
			//			digit = nextDigit - digit;
			//			ptr++;
			//		}
			//	}

			//	values.Add(digit);
			//	ptr++;
			//}

			//int total = 0;
			//foreach (int digit in values)
			//	total += digit;

			//return total;
			return 1;
		}
		private int convertStringToInteger(string input)
		{
			return Int32.Parse(input);
		}
	}
}
