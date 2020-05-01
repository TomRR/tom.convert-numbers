using System;
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
			StringBuilder romanDigit = new StringBuilder();
			List<RomanNumeral> romanNumeralList = GetRomanNumeralsListReverse();


			int i = 0;
			foreach(RomanNumeral romanNumeral in romanNumeralList)
			{
				while (arabic >= (int)romanNumeral)
				{
					bool startsWith4 = arabic.ToString().StartsWith("4");
					bool startsWith9 = arabic.ToString().StartsWith("9");
					Console.WriteLine(arabic);
					if (startsWith4)
					{
						arabic -= (int)romanNumeral;
						romanDigit.Append(romanNumeralList.ElementAt(i));
						romanDigit.Append(romanNumeralList.ElementAt(i)); Console.WriteLine("s4");
					}
					if (startsWith9)
					{
						int[] jjj = arabic.ToString().Split("");
						int ibn = arabic;
						arabic -= (int)romanNumeral;
						romanDigit.Append(romanNumeralList.ElementAt(i));
						romanDigit.Append(romanNumeralList.ElementAt(i)); Console.WriteLine("s9");
					}
					else
					{
						arabic -= (int)romanNumeral;
						romanDigit.Append(romanNumeral);
						Console.WriteLine("s");
					}
				}			
				i++;
			}
			Console.WriteLine("Romannn"+romanNumeralList.ElementAt(1));

			
			return romanDigit.ToString();
		}
		private List<RomanNumeral> GetRomanNumeralsListReverse()
		{
			List<RomanNumeral> romanNumeralList = new List<RomanNumeral>();
			foreach (var romanNumeral in Enum.GetValues(typeof(RomanNumeral)).Cast<RomanNumeral>().Reverse())
				{
				romanNumeralList.Add(romanNumeral);
				}
			return romanNumeralList;
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
