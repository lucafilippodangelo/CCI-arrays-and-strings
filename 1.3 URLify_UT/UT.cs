using _1._3_URLify;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1._3_URLify_UT
{
    [TestClass]
    public class UT
    {
        [TestMethod]
        public void replaceSpacesInInputStringOne()
        {
            var result = Implementation.replaceSpacesInInputStringOne("abcdeee");
            Assert.AreEqual  (result, "abcdeee");
            
            result = Implementation.replaceSpacesInInputStringOne("ab  cdee e");
            Assert.AreEqual(result, "ab____cdee__e");
            
        }
    }
}


