using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
            {
                return true;
            }
            else return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length% 2 == 0)
            {
                return true;
            }
            else return false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
            {

                return (num % 2 == 1) ? true : false;
            }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            return Sum(numbers);
        }

        public int SumEvens(int[] numbers)
        {
            int sum =0;
            for (int i = 0; i < numbers.Length; i+=2)
            {
               sum += numbers[i];
            }
            return sum;
           
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers.Sum() % 2 == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (long i = number -1 ; i > 0 ; i--)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            };

            return count;
        }
    }
}
