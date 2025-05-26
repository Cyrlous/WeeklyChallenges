using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Contains(null))
            {
                return false;
            }
            
            foreach (var entry in words)
            {
                if (ignoreCase)
                {
                    if (entry.ToLower() == word.ToLower())
                    {
                        return true;
                    }
                }
                else
                {
                    if (entry == word)
                    {
                        return true;
                    }
                }
                
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var index = -1;
            var uniqueIndex = true;
            
            for (int i = 0; i < str.Length; i++)
            {
                uniqueIndex = true;
                
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uniqueIndex = false;
                    }
                }
                if (uniqueIndex)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    
                    count++;
                    
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[0];
            }
            
            var nthElements = new List<double>();
            for(int i = 0; i < elements.Count; i++)
            {
                if ((i + 1) % n == 0)
                {
                    nthElements.Add(elements[i]);
                }
            }
            return nthElements.ToArray();
        }
    }
}
