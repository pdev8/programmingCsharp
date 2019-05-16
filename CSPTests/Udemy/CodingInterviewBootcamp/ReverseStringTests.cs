using CSP.Udemy.CodingInterviewBootcamp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSPTests.Udemy.CodingInterviewBootcamp
{
    [TestClass]
    public class ReverseStringTests
    {
        private readonly string testWord1 = "apple";
        private readonly string testWord2 = "hello";
        private readonly string testWord3 = "Greetings!";

        private readonly string result1 = "elppa";
        private readonly string result2 = "olleh";
        private readonly string result3 = "!sgniteerG";

        [TestMethod]
        public void ReverseString_Reverse1_Should_Return_ReversedString()
        {
            var testResult1 = ReverseString.Reverse1(testWord1);
            var testResult2 = ReverseString.Reverse1(testWord2);
            var testResult3 = ReverseString.Reverse1(testWord3);

            Assert.AreEqual(result1, testResult1);
            Assert.AreEqual(result2, testResult2);
            Assert.AreEqual(result3, testResult3);
        }

        [TestMethod]
        public void ReverseString_Reverse2_Should_Return_ReversedString()
        {
            var testResult1 = ReverseString.Reverse2(testWord1);
            var testResult2 = ReverseString.Reverse2(testWord2);
            var testResult3 = ReverseString.Reverse2(testWord3);

            Assert.AreEqual(result1, testResult1);
            Assert.AreEqual(result2, testResult2);
            Assert.AreEqual(result3, testResult3);
        }

        [TestMethod]
        public void ReverseString_Reverse3_Should_Return_ReversedString()
        {
            var testResult1 = ReverseString.Reverse3(testWord1);
            var testResult2 = ReverseString.Reverse3(testWord2);
            var testResult3 = ReverseString.Reverse3(testWord3);

            Assert.AreEqual(result1, testResult1);
            Assert.AreEqual(result2, testResult2);
            Assert.AreEqual(result3, testResult3);
        }

        [TestMethod]
        public void ReverseString_Reverse4_Should_Return_ReversedString()
        {
            var testResult1 = ReverseString.Reverse4(testWord1);
            var testResult2 = ReverseString.Reverse4(testWord2);
            var testResult3 = ReverseString.Reverse4(testWord3);

            Assert.AreEqual(result1, testResult1);
            Assert.AreEqual(result2, testResult2);
            Assert.AreEqual(result3, testResult3);
        }

        [TestMethod]
        public void ReverseString_Reverse5_Should_Return_ReversedString()
        {
            var testResult1 = ReverseString.Reverse5(testWord1);
            var testResult2 = ReverseString.Reverse5(testWord2);
            var testResult3 = ReverseString.Reverse5(testWord3);

            Assert.AreEqual(result1, testResult1);
            Assert.AreEqual(result2, testResult2);
            Assert.AreEqual(result3, testResult3);
        }
    }
}