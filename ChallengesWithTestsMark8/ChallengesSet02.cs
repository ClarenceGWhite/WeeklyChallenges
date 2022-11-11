using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0 ? true : false);
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers) //
        {
            if (numbers == null) 
            {
                return 0;
            }

            if (numbers.Count() == 0) 
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2) //
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sumOfEvens = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sumOfEvens += i;
                }
            }
            return sumOfEvens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = Sum(numbers.ToArray());
            return sum % 2 == 0 ? false : true;
        }

        public long CountOfPositiveOddsBelowNumber(long number) //
        {
            int oddsCounter = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    oddsCounter++;
                }
            }
            return oddsCounter;
        }
    }
}
