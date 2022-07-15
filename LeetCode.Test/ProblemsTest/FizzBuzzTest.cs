using NUnit.Framework;
using LeetCode.Problems;

namespace LeetCode.Test.ProblemsTest
{
    public class FizzBuzzTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FizzBuzzTest1()
        {
            Assert.AreEqual(new string[] { "1", "2", "Fizz" }, FizzBuzz.FizzBuzzRun(3));
        }

        [Test]
        public void FizzBuzzTest2()
        {
            Assert.AreEqual(new string[] { "1", "2", "Fizz", "4", "Buzz" }, FizzBuzz.FizzBuzzRun(5));
        }

        [Test]
        public void FizzBuzzTest3()
        {
            Assert.AreEqual(new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }, FizzBuzz.FizzBuzzRun(15));
        }
    }
}
