using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpHelper.Tests
{
    [TestClass]
    public class ObjectHelperTests
    {

        [TestMethod]
        public void Will_Return_True_Because_Object_Is_Null()
        {
            TestObject testObject = null;
            Assert.IsTrue(testObject.IsNull());

        }

        [TestMethod]
        public void Will_Return_False_Because_Object_Is_Not_Null()
        {
            var testObject = new TestObject();
            Assert.IsFalse(testObject.IsNull());
        }
    }

    public class TestObject
    {

    }
}