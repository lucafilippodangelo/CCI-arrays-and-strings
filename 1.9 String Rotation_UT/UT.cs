using _1._9_String_Rotation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1._9_String_Rotation_UT
{
    [TestClass]
    public class UT
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = Implementation.IsRotation("apple", "pleap");
            Assert.IsTrue(result);

            result = Implementation.IsRotation("waterbottle", "erbottlewat");
            Assert.IsTrue(result);

            result = Implementation.IsRotation("camera", "macera");
            Assert.IsFalse(result);
        }

       
    }
}
