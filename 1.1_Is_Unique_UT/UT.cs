using _1._1_Is_Unique;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1._1_Is_Unique_UT
{
    [TestClass]
    public class UT
    {
        [TestMethod]
        public void ImplementationOne_ReturnTrueOnlyIfDuplicateCharInString()
        {
            var result = Implementation.ImplementationOne("abcdefghilmnopqrrst");
            Assert.IsTrue(result);

            var resultTwo = Implementation.ImplementationOne("abcdefghilmnopqrst");
            Assert.IsFalse(resultTwo);
        }

        [TestMethod]
        public void ImplementationTwo_ReturnTrueOnlyIfDuplicateCharInString()
        {
            var result = Implementation.ImplementationTwo("abcdefghilmnopqrrst");
            Assert.IsTrue(result);

            var resultTwo = Implementation.ImplementationTwo("abcdefghilmnopqrst");
            Assert.IsFalse(resultTwo);
        }

        [TestMethod]
        public void ImplementationThree_ReturnTrueOnlyIfDuplicateCharInString()
        {
            var result = Implementation.ImplementationThree("abcdefghilmnopqrrst");
            Assert.IsTrue(result);

            var resultTwo = Implementation.ImplementationThree("abcdefghilmnopqrst");
            Assert.IsFalse(resultTwo);
        }
    }
}
