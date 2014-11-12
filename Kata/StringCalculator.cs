﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class StringCalculator
    {
        private const int DefaultValue = 0;

        private const char DefaultSeparator = ','; 


        private readonly NumbersSanitizer _numbersSanitizer;
        private readonly NumbersExtractor _numbersExtractor; 
        public StringCalculator()
        {
            _numbersSanitizer = new NumbersSanitizer(DefaultSeparator); 
            _numbersExtractor = new NumbersExtractor(DefaultSeparator);
        }

        public int Add(string numbers)
        {

            numbers = _numbersSanitizer.SanitizeNumbers(numbers);

            if (ShouldReturnDefaultNumbers(numbers)) 
                return DefaultValue;

            var extractedNumbers = _numbersExtractor.ExtractNumbers(numbers); 
            return SumNumbers(extractedNumbers); 
        } 

        private int SumNumbers(IEnumerable<int> splitNumbers)
        {
            return splitNumbers.Sum(); 
        }

        private bool ShouldReturnDefaultNumbers(string numbers)
        {
            return numbers == String.Empty; 
        }
    }
}
