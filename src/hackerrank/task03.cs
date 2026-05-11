using System;
using System.Collections.Generic;
using Xunit;

namespace HackerRankTasks
{
    public class Task03
    {
        public static int CountFruits(int start, int end, int treePos, List<int> fruits)
        {
            int count = 0;
            foreach (int f in fruits)
            {
                int landingPos = treePos + f;
                if (landingPos >= start && landingPos <= end)
                {
                    count++;
                }
            }
            return count;
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int appleCount = CountFruits(s, t, a, apples);
            int orangeCount = CountFruits(s, t, b, oranges);

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
    }

    public class Task03Tests
    {
        [Fact]
        public void TestAppleAndOrangeCounting()
        {
            int s = 7, t = 11;
            int a = 5, b = 15;
            var apples = new List<int> { -2, 2, 1 };
            var oranges = new List<int> { 5, -6 };

            Assert.Equal(1, Task03.CountFruits(s, t, a, apples));
            Assert.Equal(1, Task03.CountFruits(s, t, b, oranges));
        }
    }
}