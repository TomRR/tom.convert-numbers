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
			int ziffer;
			char[] romZiff = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };

			int i = 0;

			string tmp, rom = "";
			for (int index = 0; arabic > 0; index += 2)
			{
				tmp = "";
				ziffer = arabic % 10;
				if (ziffer == 4)
				{
					tmp += romZiff[index];
					tmp += romZiff[index + 1];
				}
				else if (ziffer == 9)
				{
					tmp += romZiff[index];
					tmp += romZiff[index + 2];
				}
				else
				{
					if (ziffer >= 5)
					{
						tmp += romZiff[index + 1];
						ziffer -= 5;
					}
					for (; ziffer > 0; ziffer--)
					{
						tmp += romZiff[index];
					}
				}
				arabic /= 10; rom = tmp + rom;
			}
			return rom;
			//foreach(RomanNumeral romanNumeral in romanNumeralList)
			//{

			//while (arabic >= (int)romanNumeral)
			//{
			//	bool startsWith4 = arabic.ToString().StartsWith("4");
			//	bool startsWith9 = arabic.ToString().StartsWith("9");
			//	Console.WriteLine(arabic);
			//	if (startsWith4)
			//	{
			//		arabic -= (int)romanNumeral;
			//		romanDigit.Append(romanNumeralList.ElementAt(i));
			//		romanDigit.Append(romanNumeralList.ElementAt(i)); Console.WriteLine("s4");
			//	}
			//	if (startsWith9)
			//	{

			//		int ibn = arabic;
			//		arabic -= (int)romanNumeral;
			//		romanDigit.Append(romanNumeralList.ElementAt(i));
			//		romanDigit.Append(romanNumeralList.ElementAt(i)); Console.WriteLine("s9");
			//	}
			//	else
			//	{
			//		arabic -= (int)romanNumeral;
			//		romanDigit.Append(romanNumeral);
			//		Console.WriteLine("s");
			//	}
			//}			
			//i++;
			//}
			//Console.WriteLine("Romannn"+romanNumeralList.ElementAt(1));

			
			//return romanDigit.ToString();
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
			String romanNumeral = roman.ToUpper();
			int result = 0;
			List<RomanNumeral> romanNumerals = GetRomanNumeralsListReverse();
			int i = 0;
			while (((romanNumeral.Length > 0)
						&& (i < romanNumerals.Size())))
			{
				RomanNumeral symbol = romanNumerals.get(i);
				if (romanNumeral.StartsWith(symbol.name()))
				{
					result = (result + symbol.GetValues());
					romanNumeral = romanNumeral.Substring(symbol.name().Length());
				}
				else
				{
					i++;
				}

			}

			if ((romanNumeral.length() > 0))
			{
				throw new IllegalArgumentException((input + " cannot be converted to a Roman Numeral"));
			}

			return result;
			//char[] romZiff = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
			//int[] romWert = { 1, 5, 10, 50, 100, 500, 1000 };
			//int dec = 0;
			//int lastVal = 0, curVal;
			//char[] ziffern = roman.ToUpper().ToCharArray();
			//for (int i = ziffern.Length - 1; i >= 0; i--)
			//{
			//	curVal = 0;
			//	for (int j = 0; j < romZiff.Length; j++)
			//	{
			//		if (ziffern[i] == romZiff[j])
			//		{
			//			curVal = romWert[j];
			//			break;
			//		}
			//	}

			//	if (curVal == 0)
			//	{
			//		return -1;
			//	}
			//	if (curVal >= lastVal)
			//	{
			//		dec += curVal;
			//	}
			//	else
			//	{
			//		dec -= curVal;
			//		lastVal = curVal;
			//	}

			//}
			//return dec;
		}
			private int convertStringToInteger(string input)
		{
			return Int32.Parse(input);
		}
	}
}
