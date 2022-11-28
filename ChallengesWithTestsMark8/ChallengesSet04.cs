using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum -= i;
                }
            }
            return sum;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            int shortestLen = 100000;
            if (str1.Length < shortestLen)
            {
                shortestLen = str1.Length;
            }
            if (str2.Length < shortestLen)
            {
                shortestLen = str2.Length;
            }
            if (str3.Length < shortestLen)
            {
                shortestLen = str3.Length;
            }
            if (str4.Length < shortestLen)
            {
                shortestLen = str4.Length;
            }
            return shortestLen;


        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int lowestVal = 1000;
            if (number1 < lowestVal)
            {
                lowestVal = number1;
            }
            if (number2 < lowestVal)
            {
                lowestVal = number2;
            }
            if (number3 < lowestVal)
            {
                lowestVal = number3;
            }
            if (number4 < lowestVal)
            {
                lowestVal = number4;
            }
            return lowestVal;

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {

            if (sideLength1 + sideLength2 > sideLength3
                && sideLength1 + sideLength3 > sideLength2
                && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
                return false;

        }

        public bool IsStringANumber(string input)
        {

            if (double.TryParse(input, out double value))
            {
                return true;
            }
                return false;

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {

            int itemCt = objs.Length;
            int nullCt = 0;
            foreach (object obj in objs)
            {
                if (obj == null) nullCt++;
            }
            if (nullCt > itemCt / 2)
            {
                return true;
            }
                return false;

        }

        public double AverageEvens(int[] numbers)
        {

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int evenSum = 0;
            int evenCt = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                    evenCt++;
                }
            }
            if (evenCt == 0)
            {
                return 0;
            }
            return (double)evenSum / evenCt;

        }

        public int Factorial(int number)
        {
            
            if (number < 0) throw new ArgumentOutOfRangeException();
            if (number == 0) return 1;
            if (number > 1)
            {
                return number * Factorial(number - 1);
            }
            else
            {
                return number;
            }

        }
    }
}
