using System;
using Xunit;

namespace HackerRankTasks
{
    public class Task10
    {
        public static int pageCount(int n, int p)
        {
            int fromFront = p / 2;
            int fromBack = (n / 2) - (p / 2);

            return Math.Min(fromFront, fromBack);
        }
    }

    public class Task10Tests
    {
        [Fact]
        public void TestPageCountSample0()
        {
            int n = 6;
            int p = 2;
            int expected = 1;

            int result = Task10.pageCount(n, p);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestPageCountSample1()
        {
            int n = 5;
            int p = 4;
            int expected = 0;

            int result = Task10.pageCount(n, p);

            Assert.Equal(expected, result);
        }
    }
}