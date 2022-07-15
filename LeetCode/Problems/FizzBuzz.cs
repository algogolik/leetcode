using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public static class FizzBuzz
    {
        /// <summary>
        /// FizzBuzz is a childhood game that iterates over a range of numbers 
        /// and uses simple logic to decide whether to say a "Fizz," "Buzz," or a number
        /// Time complexity = O(n)
        /// Space complexity = O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns>a string array answer (1-indexed) where:
        /// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
        /// answer[i] == "Fizz" if i is divisible by 3.
        /// answer[i] == "Buzz" if i is divisible by 5.
        /// answer[i] == i (as a string) if none of the above conditions are true.
        /// </returns>
        public static IList<string> FizzBuzzRun(int n)
        {
            // Input: n = 3
            // Output: ["1","2","Fizz"]
            var answer = new List<string>(n + 1);
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    answer.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    answer.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    answer.Add("Buzz");
                }
                else 
                {
                    answer.Add(i.ToString());
                }
            }

            return answer;
        }
    }
}
