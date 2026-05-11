using System;
using System.Collections.Generic;
using Xunit;

namespace HackerRankTasks
{
    public class Task02
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();

            foreach (int grade in grades)
            {
                if (grade < 38)
                {
                    result.Add(grade);
                }
                else
                {                 
                    int nextMultipleOfFive = ((grade / 5) + 1) * 5;
                    if (nextMultipleOfFive - grade < 3)
                        result.Add(nextMultipleOfFive);
                    else
                        result.Add(grade);
                }
            }
            return result;
        }
    }

    public class Task02Tests
    {
        [Fact]
        public void TestGrading()
        {
            
            var input = new List<int> { 73, 67, 33 };
            var expected = new List<int> { 75, 67, 33 };

            var actual = Task02.gradingStudents(input);

            Assert.Equal(expected, actual);
        }
    }
}