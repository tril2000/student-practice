using System;
using Xunit;

namespace HackerRankTasks
{
    public class Task01
    {
        public static string GetStaircase(int n)
        {
            var result = new System.Text.StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string hashes = new string('#', i);
                result.Append(spaces + hashes);
                if (i < n) result.Append(Environment.NewLine);
            }
            return result.ToString();
        }

        public static void staircase(int n)
        {
            Console.WriteLine(GetStaircase(n));
        }
    }

    public class Task01Tests
    {
        [Fact]
        public void TestStaircaseSize4()
        {
            string expected = "   #" + Environment.NewLine +
                              "  ##" + Environment.NewLine +
                              " ###" + Environment.NewLine +
                              "####";

            string actual = Task01.GetStaircase(4);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestStaircaseSize1()
        {
            string expected = "#";
            string actual = Task01.GetStaircase(1);
            Assert.Equal(expected, actual);
        }
    }
}