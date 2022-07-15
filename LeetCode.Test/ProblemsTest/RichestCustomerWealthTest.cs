using NUnit.Framework;
using LeetCode.Problems;

namespace LeetCode.Test.ProblemsTest
{
    public class RichestCustomerWealthTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MaximumWealthTest1()
        {
            Assert.AreEqual(6, RichestCustomerWealth.MaximumWealth(new int[2][] { new int[3] { 1, 2, 3 }, new int[3] { 3, 2, 1 } }));
        }

        [Test]
        public void MaximumWealthTest2()
        {
            Assert.AreEqual(10, RichestCustomerWealth.MaximumWealth(new int[3][] { new int[2] { 1, 5 }, new int[2] { 7, 3 }, new int[2] { 3, 5 } }));
        }

        [Test]
        public void MaximumWealthTest3()
        {
            Assert.AreEqual(17, RichestCustomerWealth.MaximumWealth(new int[3][] { new int[3] { 2, 8, 7 }, new int[3] { 7, 1, 3 }, new int[3] { 1, 9, 5 } }));
        }
    }
}
