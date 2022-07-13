using NUnit.Framework;
using LeetCode;

namespace LeetCode.Test
{
    public class RunningSumof1dArrayTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RunningSumof1dArrayTest1()
        {
            Assert.AreEqual(new int[] { 1, 3, 6, 10 }, RunningSumof1dArray.RunningSum(new int[] { 1, 2, 3, 4 }));
        }

        [Test]
        public void RunningSumof1dArrayTest2()
        {
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, RunningSumof1dArray.RunningSum(new int[] { 1, 1, 1, 1, 1 }));
        }

        [Test]
        public void RunningSumof1dArrayTest3()
        {
            Assert.AreEqual(new int[] { 3, 4, 6, 16, 17 }, RunningSumof1dArray.RunningSum(new int[] { 3, 1, 2, 10, 1 }));
        }
    }
}