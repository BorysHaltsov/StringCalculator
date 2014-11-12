using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    class NumbersExtractor
    {
        private readonly char _defaultSeparator;

        public NumbersExtractor(char defaultSeparator)
        {
            _defaultSeparator = defaultSeparator; 
        }
        public List<int> ExtractNumbers(string numbers)
        {
            var numbersList = ConvertToNumbersList(numbers);
            numbersList = RemoveNegativeNumbers(numbersList);
            return numbersList;  
        }

        private List<int> RemoveNegativeNumbers(IEnumerable<int> splitNumbers)
        {
            return splitNumbers.Where(x => x >= 0).ToList();
        }

        private List<int> ConvertToNumbersList(string numbers)
        {
            var splitNumbers = SplitNumbers(numbers);
            return splitNumbers.Select(ConvertToSingleNumber).ToList();
        }

        private IEnumerable<string> SplitNumbers(string numbers)
        {
            return numbers.Split(_defaultSeparator);
        }

        private static int ConvertToSingleNumber(string numbers)
        {
            return Int32.Parse(numbers);
        }
    }
}
