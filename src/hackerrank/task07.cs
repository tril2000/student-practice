using System;
using System.Collections.Generic;
using Xunit;

namespace HackerRankTasks
{
    public class Task07
    {
        public static int migratoryBirds(List<int> arr)
        {
            if (arr == null || arr.Count == 0)
                return 0;

            int[] birdCounts = new int[6];

            foreach (int birdId in arr)
            {
                birdCounts[birdId]++;
            }

            int maxFrequency = 0;
            int mostFrequentBirdId = 1;

            for (int i = 1; i <= 5; i++)
            {
                if (birdCounts[i] > maxFrequency)
                {
                    maxFrequency = birdCounts[i];
                    mostFrequentBirdId = i;
                }
            }

            return mostFrequentBirdId;
        }
    }

    public class Task07Tests
    {
        [Fact]
        public void TestMigratoryBirdsSample0()
        {
            var arr = new List<int> { 1, 4, 4, 4, 5, 3 };
            int expected = 4;

            int result = Task07.migratoryBirds(arr);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMigratoryBirdsSample1()
        {
            var arr = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };
            int expected = 3;

            int result = Task07.migratoryBirds(arr);

            Assert.Equal(expected, result);
        }
    }
}