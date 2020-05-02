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
			StringBuilder romanDigit = new StringBuilder();
			List<RomanNumeral> romanNumeralList = GetRomanNumeralsListReverse();

			RomanNumeral ro = new RomanNumeral();
			Console.WriteLine(romanNumeralList.ElementAt(1));
			int ziffer;
			char[] romZiff = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };

			int i = 0;

			//string tmp, rom = "";
			//for (int index = 0; arabic > 0; index += 2)
			//{
			//	tmp = "";
			//	ziffer = arabic % 10;
			//	if (ziffer == 4)
			//	{
			//		romanDigit.Append(romanNumeralList.ElementAt(index));
			//		romanDigit.Append(romanNumeralList.ElementAt(index + 1));
			//		tmp += romanNumeralList.ElementAt(index);
			//		//tmp += romZiff[index + 1];
			//	}
			//	else if (ziffer == 9)
			//	{
			//		romanDigit.Append(romanNumeralList.ElementAt(index));
			//		romanDigit.Append(romanNumeralList.ElementAt(index + 2));
			//		//tmp += romZiff[index];
			//		//tmp += romZiff[index + 2];
			//	}
			//	else
			//	{
			//		if (ziffer >= 5)
			//		{
			//			romanDigit.Append(romanNumeralList.ElementAt(index + 1));
			//			ziffer -= 5;
			//		}
			//		for (; ziffer > 0; ziffer--)
			//		{
			//			romanDigit.Append(romanNumeralList.ElementAt(index));
			//		}
			//	}
			//	arabic /= 10; rom = tmp + rom;
			//}
			//return rom;
			foreach (RomanNumeral romanNumeral in romanNumeralList)
			{
				ziffer = arabic % 10;

				while (arabic >= (int)romanNumeral)
				{
					bool startsWith4 = arabic.ToString().StartsWith("4");
					bool startsWith9 = arabic.ToString().StartsWith("9");
					Console.WriteLine(arabic);
					if (startsWith4)
					{
						romanDigit.Append(romanNumeralList.ElementAt(i));
						romanDigit.Append(romanNumeralList.ElementAt(i + 1)); ;
					}
					if (startsWith9)
					{

						int ibn = arabic;
						arabic -= (int)romanNumeral;
						romanDigit.Append(romanNumeralList.ElementAt(i));
						romanDigit.Append(romanNumeralList.ElementAt(i + 2));
					}
					else
					{
						arabic -= (int)romanNumeral;
						romanDigit.Append(romanNumeral);
						Console.WriteLine("s");
					}
					if (ziffer >= 5)
					{
						romanDigit.Append(romanNumeralList.ElementAt(i + 1));
						ziffer -= 5;
					}
					for (; ziffer > 0; ziffer--)
					{
						romanDigit.Append(romanNumeralList.ElementAt(i));
					}
				}
				i++;
			}
			Console.WriteLine("Romannn" + romanNumeralList.ElementAt(1));


			return romanDigit.ToString();
		}
		private List<RomanNumeral> GetRomanNumeralsListReverse()
		{
			List<RomanNumeral> romanNumeralList = new List<RomanNumeral>();
			foreach (var romanNumeral in Enum.GetValues(typeof(RomanNumeral)).Cast<RomanNumeral>().ToList())
				{
				romanNumeralList.Add(romanNumeral);
				}
			return romanNumeralList;
		}

		public int RomanToArabic(string roman)
		{
			String romanNumeral = roman.ToUpper();
			if (roman == "NULLA") return 0;

			int ptr = 0;
			ArrayList values = new ArrayList();
			int maxDigit = 1000;
			while (ptr < roman.Length)
			{
				char numeral = roman[ptr];
				int digit = (int)Enum.Parse(typeof(RomanNumeral), numeral.ToString());

				int nextDigit = 0;
				if (ptr < roman.Length - 1)
				{
					char nextNumeral = roman[ptr + 1];
					nextDigit = (int)Enum.Parse(typeof(RomanNumeral), nextNumeral.ToString());

					if (nextDigit > digit)
					{
						maxDigit = digit - 1;
						digit = nextDigit - digit;
						ptr++;
					}
				}

				values.Add(digit);
				ptr++;
			}

			int total = 0;
			foreach (int digit in values)
				total += digit;

			return total;
		}
	}
}
