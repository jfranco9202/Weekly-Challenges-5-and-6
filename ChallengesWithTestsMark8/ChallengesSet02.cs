using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var input = c.ToString();

            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";

            foreach (char letter in lowercaseAlphabet)
            {
                if (letter.ToString().Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Count() % 2 == 0;

        }

        public bool IsNumberEven(int number)
        {

            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            double max = numbers.Max();
            double min = numbers.Min();
            return max + min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int len = str1.Length;
            int len1 = str2.Length;

            if (len < len1)
            {
                return len;
            }
            else
            {
                return len1;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = numbers.Sum();
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            return numbers.Where(x => x % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            
            var sum = numbers.Sum();


            if (sum % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int intNumber = (int)number;
            var count = 0;

            for (var i = 0; i < intNumber; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }


    } 
}

