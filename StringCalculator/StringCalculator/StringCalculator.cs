using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator
{
    class StringCalculator
    {
        private char[] ExtractDelimiters(string numbers)
        {

        }

        public int add(String numbers) 
        {
            String[] digits = null;
            int sum = 0;
            char[] delimiters = new char[2];

            if (numbers.StartsWith("//"))
            {
                delimiters[0] = numbers[2];
                numbers = numbers.Substring(3);
            }
            else
            {
                delimiters[0] = ',';
                delimiters[1] = '\n';
            }

            if (numbers.Equals(""))
            {
                return 0;
            }

            digits = numbers.Split(delimiters);

            foreach (string digit in digits)
            {
                sum += int.Parse(digit);
            }
            return sum;
        }
    }
}