using NUnit.Framework;
using Tom.ConvertNumbers;

namespace Tom.ConvertNumbersTest
{
    [TestFixture]
    public class ConvertingLogicTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArabicToRoman_InputArabicNumber_ReturnsCorrectString()
        {
            ConvertingLogic number = new ConvertingLogic();

            string result = number.ArabicToRoman(1059);

            Assert.That(result, Is.EqualTo("MLIX"));
        }                
        
        [Test]
        public void RomanToArabic_InputRomanNumberal_ReturnsCorrectinteger()
        {
            ConvertingLogic number = new ConvertingLogic();

            int result = number.RomanToArabic("MLIX");
            
            Assert.That(result, Is.EqualTo(1059));
        }
    }
}