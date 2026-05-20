using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HackerRankTasks
{
    public class Task05
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            int count = 0;
            
            int start = a.Max();
            int end = b.Min();

            for (int x = start; x <= end; x++)
            {
                bool condition1 = a.All(element => x % element == 0);
                
                bool condition2 = b.All(element => element % x == 0);

                if (condition1 && condition2)
                {
                    count++;
                }
            }

            return count;
        }
    }

    public class Task05Tests
    {
        [Fact]
        public void TestBetweenTwoSetsSample()
        {
            
            var a = new List<int> { 2, 4 };
            var b = new List<int> { 16, 32, 96 };

            int result = Task05.getTotalX(a, b);

            Assert.Equal(3, result);
        }
    }
}