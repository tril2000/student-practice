using System;
using System.Collections.Generic;
using Xunit;

namespace HackerRankTasks
{
    public class Task09
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            if (arr == null || arr.Count == 0)
                return 0;

            int n = arr.Count;
            int primarySum = 0;
            int secondarySum = 0;

            for (int i = 0; i < n; i++)
            {
                primarySum += arr[i][i];
                secondarySum += arr[i][n - 1 - i];
            }

            return Math.Abs(primarySum - secondarySum);
        }
    }

    public class Task09Tests
    {
        [Fact]
        public void TestDiagonalDifferenceSample()
        {
            var matrix = new List<List<int>>
            {
                new List<int> { 11, 2, 4 },
                new List<int> { 4, 5, 6 },
                new List<int> { 10, 8, -12 }
            };
            int expected = 15;

            int result = Task09.diagonalDifference(matrix);

            Assert.Equal(expected, result);
        }
    }
}