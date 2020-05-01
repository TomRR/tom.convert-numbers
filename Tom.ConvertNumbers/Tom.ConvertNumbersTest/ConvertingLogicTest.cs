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
        public void ArabicToRoman_Input1059ArabicNumber_ReturnsMLIX()
        {
            ConvertingLogic number = new ConvertingLogic();

            string result = number.ArabicToRoman(1059);

            Assert.That(result, Is.EqualTo("MLIX"));
        }                
        
        [Test]
        public void RomanToArabic_InputMLIXRomanNumberal_Returns1059()
        {
            ConvertingLogic number = new ConvertingLogic();

            int result = number.RomanToArabic("MLIX");
            
            Assert.That(result, Is.EqualTo(1059));
        }
    }
}