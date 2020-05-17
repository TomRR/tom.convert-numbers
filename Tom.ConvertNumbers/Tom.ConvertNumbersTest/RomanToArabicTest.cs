using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tom.ConvertNumbers;

namespace Tom.ConvertNumbersTest
{
    [TestFixture]
    public class RomanToArabicTest
    {
        [Test]
        public void RomanToArabic_InputIVRomanNumberal_Returns4()
        {
            ConvertingLogic number = new ConvertingLogic();
            string romanIV = "IV";

            int result = number.RomanToArabic(romanIV);

            Assert.That(result, Is.EqualTo(4));
        }
        [Test]
        public void RomanToArabic_InputVIIIRomanNumberal_Returns8()
        {
            ConvertingLogic number = new ConvertingLogic();
            string romanVIII = "VIII";

            int result = number.RomanToArabic(romanVIII);

            Assert.That(result, Is.EqualTo(8));
        }
        [Test]
        public void RomanToArabic_InputIXRomanNumberal_Returns9()
        {
            ConvertingLogic number = new ConvertingLogic();
            string romanIX = "IX";

            int result = number.RomanToArabic(romanIX);

            Assert.That(result, Is.EqualTo(9));
        }
        [Test]
        public void RomanToArabic_InputCMRomanNumberal_Returns900()
        {
            ConvertingLogic number = new ConvertingLogic();
            string romanCM = "CM";

            int result = number.RomanToArabic(romanCM);

            Assert.That(result, Is.EqualTo(900));
        }        
        [Test]
        public void RomanToArabic_InputXRomanNumberal_Returns10()
        {
            ConvertingLogic number = new ConvertingLogic();
            string romanX = "X";

            int result = number.RomanToArabic(romanX);

            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void RomanToArabic_InputMLIXRomanNumberal_Returns1059()
        {
            ConvertingLogic number = new ConvertingLogic();
            string romanMLIX = "MLIX";

            int result = number.RomanToArabic(romanMLIX);

            Assert.That(result, Is.EqualTo(1059));
        }
    }
}
