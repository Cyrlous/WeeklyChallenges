using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int answer = 0;
            foreach (int number in numbers)
            {
               answer = number %2 == 0 ? answer += number : answer -= number;
            }
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var stringList = new List<string>() {str2, str3, str4};
            var shortString = str1;

            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].Length < shortString.Length)
                {
                    shortString = stringList[i];
                }
            }
            return shortString.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numList = new List<int>() {number2, number3, number4 };
            var smallNumber = number1;
            
            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] < smallNumber)
                {
                    smallNumber = numList[i];
                }
            }
            return smallNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return(sideLength1 + sideLength2 > sideLength3 && 
                   sideLength2 + sideLength3 > sideLength1 &&
                   sideLength1 + sideLength3 > sideLength2);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int isNull = 0;
            int notNull = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    isNull++;
                }
                else
                {
                    notNull++;
                }
            }
            return isNull > notNull;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            var averageEvens = numbers.Where(x => x % 2 == 0);
            
            if (averageEvens.Count() == 0)
            {
                return 0;
            }
            
            return averageEvens.Average();
        }

        public int Factorial(int number)
        {
            var factorial = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
