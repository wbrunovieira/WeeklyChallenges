using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double substractResult = (minuend - subtrahend);

            return substractResult;
        }

        public int Add(int number1, int number2)
        {
            int addResult = (number1 + number2);

            return addResult;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            
            if(number1 > number2)
            {
                return number2;
            }
            else
            {
                return number1;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            long multiplyResult = (factor1 * factor2);

            return multiplyResult;
        }

        public string GetGreeting(string personName)
        {
            if (personName == "")
            {
                return "Hello!";
            }

            else
            {
                return $"Hello, {personName}!";
            }
           
        }

        public string GetHey()
        {
          
            return "HEY!";
        }
        
    }
}
