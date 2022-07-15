using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public static class RichestCustomerWealth
    {
        /// <summary>
        /// You are given an m x n integer grid accounts where accounts[i][j] is the amount of money 
        /// the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. 
        /// A customer's wealth is the amount of money they have in all their bank accounts. 
        /// The richest customer is the customer that has the maximum wealth.
        /// Time complexity = O(n x m)
        /// Space complexity = O(1)
        /// #1672. https://leetcode.com/problems/richest-customer-wealth/submissions/
        /// </summary>
        /// <param name="accounts"></param>
        /// <returns>Return the wealth that the richest customer has.</returns>
        public static int MaximumWealth(int[][] accounts)
        {
            // Input: accounts = [[1,2,3],[3,2,1]]
            // Output: 6
            // Explanation:
            // 1st customer has wealth = 1 + 2 + 3 = 6
            // 2nd customer has wealth = 3 + 2 + 1 = 6
            // Both customers are considered the richest with a wealth of 6 each, so return 6
            var maxWealthSoFar = 0;
            for (var i = 0; i < accounts.Length; i++)
            {
                var currentCustomerWealth = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    currentCustomerWealth += accounts[i][j];
                }

                if (currentCustomerWealth > maxWealthSoFar)
                    maxWealthSoFar = currentCustomerWealth;
            }

            return maxWealthSoFar;
        }
    }
}
