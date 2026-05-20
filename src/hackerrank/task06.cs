using System;
using System.Collections.Generic;
using Xunit;

namespace HackerRankTasks
{
    public class Task06
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            if (scores == null || scores.Count == 0) 
                return new List<int> { 0, 0 };

            int maxRecord = scores[0];
            int minRecord = scores[0];

            int maxCount = 0;
            int minCount = 0;

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] > maxRecord)
                {
                    maxRecord = scores[i];
                    maxCount++;
                }
                else if (scores[i] < minRecord)
                {
                    minRecord = scores[i];
                    minCount++;
                }
            }
            return new List<int> { maxCount, minCount };
        }
    }

    public class Task06Tests
    {
        [Fact]
        public void TestBreakingRecordsSample()
        {
            var scores = new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            var expected = new List<int> { 2, 4 };

            var result = Task06.breakingRecords(scores);

            Assert.Equal(expected, result);
        }
    }
}