﻿using System;
using System.Collections.Generic;

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

                return num % 2 == 1;
            }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
