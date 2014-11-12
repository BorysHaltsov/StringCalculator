using NUnit.Framework;

namespace Kata
{
    [TestFixture]
    public class NumberSanitizerTests
    { 

        [TestCase("//;\n1;2", "1,2")]
        [TestCase("//&\n1&2", "1,2")]
        public void Add_WhenContainsSeparatorSpecifier_ReturnsSumOfNumbers(string numbers, string expected)
        {
            ArrangeActAndAssert(numbers, expected);
        }

        private void ArrangeActAndAssert(string numbers, string expected)
        {
            var numbersSanitizer = new NumbersSanitizer(',');
            var result = numbersSanitizer.SanitizeNumbers(numbers); 
            Assert.AreEqual(expected, result); 
        }
    }
}