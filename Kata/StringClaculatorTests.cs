using NUnit.Framework;

namespace Kata
{
    [TestFixture]
    public class StringClaculatorTests
    {
        [Test]

        public void Add_WhenEmptyString_Returns0()
        {
            ArrangeActAndAssert("", 0);
        }

        [TestCase("1",1)] 
        [TestCase("2",2)] 
         
        public void Add_WhenSingleNumber_ReturnsThatNumber(string numbers, int expected)
        {
            ArrangeActAndAssert(numbers, expected);  
        }

        private static void ArrangeActAndAssert(string numbers, int expected)
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase("1,2", 3)] 
        [TestCase("3,4", 7)]
        public void Add_WhenMultipleNumbers_ReturnsSumOfNumbers(string numbers, int expected)
        {
            ArrangeActAndAssert(numbers, expected);
        }

        [Test]
        [TestCase("1,2,3", 6)]
        [TestCase("1,2,3,4", 10)]

        public void Add_WhenUnknownAmountOfNumbers_ReturnsSumOfNumbers(string numbers, int expected)
        {
            ArrangeActAndAssert(numbers, expected);
        }

        [Test]
        public void Add_WhenNumbersAreSplitedWithNewLine_ReturnsSumOfNumbers()
        {
            ArrangeActAndAssert("1\n2,3", 6);
        }
        
        [TestCase("//;\n1;2", 3)]
        [TestCase("//&\n1&2", 3)]
        public void Add_WhenContainsSeparatorSpecifier_ReturnsSumOfNumbers(string numbers, int expected)
        {
            ArrangeActAndAssert(numbers, expected);
        }

        [TestCase("1,-2,3", 4)]
        [TestCase("1,2,-3", 3)] 

        public void Add_WhenContainsNegativeNumbers_ExcludeThemFromSum(string numbers, int expected)
        {
            ArrangeActAndAssert(numbers, expected);
        }
    }
}