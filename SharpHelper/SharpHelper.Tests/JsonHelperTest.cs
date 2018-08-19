using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpHelper.Tests
{
    [TestClass]
    public class JsonHelperTest
    {
        [TestMethod]
        public void Will_Convert_Object_To_Right_Json_String_And_Convert_Back_To_Json_Object()
        {
            var testObject = new TestJsonObject
            {
                MyFirstProperty = "Test String",
                MySecondProperty = 15555,
                MyThirdProperty = true
            };

            var result = testObject.ToJsonString();
            var resultObject = result.ToJsonObject<TestJsonObject>();

            Assert.AreEqual(resultObject.MyFirstProperty, testObject.MyFirstProperty);
            Assert.AreEqual(resultObject.MySecondProperty, testObject.MySecondProperty);
            Assert.AreEqual(resultObject.MyThirdProperty, testObject.MyThirdProperty);
        }
    }



    public class TestJsonObject
    {
        public string MyFirstProperty { get; set; }
        public int MySecondProperty { get; set; }
        public bool MyThirdProperty { get; set; }
    }
}