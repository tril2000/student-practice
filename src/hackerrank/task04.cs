using System;
using Xunit;

namespace HackerRankTasks
{
    public class Task04
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
          
            if (v1 > v2 && (x2 - x1) % (v1 - v2) == 0)
            {
                return "YES";
            }
            
            return "NO";
        }
    }

    public class Task04Tests
    {
        [Fact]
        public void TestKangaroosMeet()
        {
     
            Assert.Equal("YES", Task04.kangaroo(0, 3, 4, 2));
        }

        [Fact]
        public void TestKangaroosNeverMeet()
        {
           
            Assert.Equal("NO", Task04.kangaroo(0, 2, 5, 3));
        }
    }
}