using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1._4_Palindrome_and_Permutation;

namespace _1._4_Palindrome_and_Permutation_UT
{
    [TestClass]
    public class UT
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = Implementation.IsPermutationOfPalindrome("Tacotac");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod11()
        {
            var result = Implementation.IsPermutationOfPalindrome3("Tacotac");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod111()
        {
            var result = Implementation.IsPermutationOfPalindrome3("Tacotacc");
            Assert.IsFalse(result);
        }
    }
}
