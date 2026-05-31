using System;
using System.Collections.Generic;
using Xunit;

namespace HackerRankTasks
{
    public class Task08
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            if (ar == null || ar.Count == 0)
                return 0;

            HashSet<int> unmatchedSocks = new HashSet<int>();
            int pairsCount = 0;

            foreach (int sock in ar)
            {
                if (unmatchedSocks.Contains(sock))
                {
                    pairsCount++;
                    unmatchedSocks.Remove(sock);
                }
                else
                {
                    unmatchedSocks.Add(sock);
                }
            }

            return pairsCount;
        }
    }

    public class Task08Tests
    {
        [Fact]
        public void TestSockMerchantSample()
        {
            int n = 9;
            var ar = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int expected = 3;

            int result = Task08.sockMerchant(n, ar);

            Assert.Equal(expected, result);
        }
    }
}