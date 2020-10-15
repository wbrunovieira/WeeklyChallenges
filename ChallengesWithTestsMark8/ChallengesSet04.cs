using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var answer = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    answer += numbers[i];
                }
                if (numbers[i] % 2 != 0)
                {
                    answer -= numbers[i];
                }
            }
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var a = new List<string>();

            a.Add(str1);
            a.Add(str2);
            a.Add(str3);
            a.Add(str4);
            int answer = str1.Length;
            for (int i = 0; i < a.Count; i++)
            {
                if (answer > a[i].Length)
                {
                    answer = a[i].Length;
                }
            }
            return answer;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(Math.Min(number1, number2), number3), number4);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool tri = sideLength1 + sideLength2 > sideLength3;
            bool an = sideLength2 + sideLength3 > sideLength1;
            bool gle = sideLength3 + sideLength1 > sideLength2;

            return tri && an && gle;
        }

        public bool IsStringANumber(string input)
        {
            double a = 0;
            var answer = Double.TryParse(input, out a);

            return answer;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var count = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    count++;
                }
            }
            if (count > (objs.Length / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var a = new List<double>();
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    a.Add(numbers[i]);
                }
            }
            for (int i = 0; i < a.Count; i++)
            {
                sum += a[i];
            }
            if (a.Count == 0)
            {
                return 0;
            }
            else
            {
                return sum / a.Count;
            }

        }

        public int Factorial(int number)
        {
            int fact = number;
            if (fact < 0)
            {
                throw new ArgumentOutOfRangeException("age", "All factorials must be positive.");
            }
            if (fact == 0)
            {
                fact = 1;
            }
            for (int i = number - 1; i >= 1; i--)
            {

                if (i > 0)
                {
                    i = Math.Abs(i);
                }
                fact *= i;

            }
            return fact;
        }
    }
}
