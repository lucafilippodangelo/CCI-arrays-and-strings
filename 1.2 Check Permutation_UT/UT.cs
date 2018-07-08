using _1._2_Check_Permutation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1._2_Check_Permutation_UT
{
    [TestClass]
    public class UT
    {
        [TestMethod]
        public void CheckPermutationOne_ReturnTrueIfPermutation()
        {
            var result = Implementation.CheckPermutationOne("abcdeee", "eeedcba");
            Assert.IsTrue(result);

            result = Implementation.CheckPermutationOne("eabcdee", "eeedcba");
            Assert.IsTrue(result);

            result = Implementation.CheckPermutationOne("eabcdeew", "teeedcba");//LD different because of "w" and "t"
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckPermutationTwo_ReturnTrueIfPermutation()
        {
            var result = Implementation.CheckPermutationTwo("abcdeee", "eeedcba");
            Assert.IsTrue(result);

            result = Implementation.CheckPermutationTwo("eabcdee", "eeedcba");
            Assert.IsTrue(result);

            result = Implementation.CheckPermutationTwo("eabcdeew", "teeedcba");//LD different because of "w" and "t"
            Assert.IsFalse(result);
        }
    }
}
