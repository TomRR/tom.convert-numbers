using NUnit.Framework;
using System.ComponentModel.Design;
using Tom.ConvertNumbers;

namespace Tom.ConvertNumbersTest
{
    [TestFixture]
    public class ArabicToRomanTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArabicToRoman_Input4ArabicNumber_ReturnsIV()
        {
            ConvertingLogic number = new ConvertingLogic();
            int arabic4 = 4;

            string result = number.ArabicToRoman(arabic4);

            Assert.That(result, Is.EqualTo("IV"));         
        }        
        [Test]
        public void ArabicToRoman_Input8ArabicNumber_ReturnsVIII()
        {
            ConvertingLogic number = new ConvertingLogic();
            int arabic8 = 8;

            string result = number.ArabicToRoman(arabic8);

            Assert.That(result, Is.EqualTo("VIII"));
        }         
        
        [Test]
        public void ArabicToRoman_Input9ArabicNumber_ReturnsIX()
        {
            ConvertingLogic number = new ConvertingLogic();
            int arabic9 = 9;

            string result = number.ArabicToRoman(arabic9);

            Assert.That(result, Is.EqualTo("IX"));
        }
        [Test]
        public void ArabicToRoman_Input10ArabicNumber_ReturnsX()
        {
            ConvertingLogic number = new ConvertingLogic();
            int arabic10 = 10;

            string result = number.ArabicToRoman(arabic10);

            Assert.That(result, Is.EqualTo("X"));
        }
        [Test]
        public void ArabicToRoman_Input900ArabicNumber_ReturnsCM()
        {
            ConvertingLogic number = new ConvertingLogic();
            int arabic900 = 900;

            string result = number.ArabicToRoman(arabic900);

            Assert.That(result, Is.EqualTo("CM"));
        }        
        [Test]
        public void ArabicToRoman_Input1059ArabicNumber_ReturnsMLIX()
        {
            ConvertingLogic number = new ConvertingLogic();
            int arabic1059 = 1059;

            string result = number.ArabicToRoman(arabic1059);

            Assert.That(result, Is.EqualTo("MLIX"));
        }                
    }
}