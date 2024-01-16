using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        private readonly long _numberLong;

        public FizzBuzz(long numberLong)
        {
            _numberLong = numberLong;
        }

        public string IsDivisible()
        {
            var answerIsDivisibleByThree = String.Empty;
            var answerIsDivisibleByFive = String.Empty;
            string answerIsDivisibleByBoth;

            if (_numberLong % 3 == 0)
            {
                answerIsDivisibleByThree = "Fizz";
            }

            if (_numberLong % 5 == 0)
            {
                answerIsDivisibleByFive = "Buzz";
            }

            answerIsDivisibleByBoth = answerIsDivisibleByThree + answerIsDivisibleByFive;

            if (string.IsNullOrWhiteSpace(answerIsDivisibleByBoth))
            {
                answerIsDivisibleByBoth = _numberLong.ToString();
            }
            return answerIsDivisibleByBoth;
        }
    }
}
