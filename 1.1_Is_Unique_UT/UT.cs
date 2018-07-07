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
            var result = Implementation.ImplementationOne("asdfaa");
            Assert.IsTrue(result);

            var resultTwo = Implementation.ImplementationOne("aeiou");
            Assert.IsFalse(resultTwo);
        }

        [TestMethod]
        public void ImplementationTwo_ReturnTrueOnlyIfDuplicateCharInString()
        {
            var result = Implementation.ImplementationTwo("asdfaa");
            Assert.IsTrue(result);

            var resultTwo = Implementation.ImplementationTwo("aeiou");
            Assert.IsFalse(resultTwo);
        }

    }
}
