using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpHelper.Tests
{
    [TestClass]
    public class EnumHelperTest
    {
        [TestMethod]
        public void Will_Return_Description_Of_Enum()
        {
            var result1 = TestEnum.Value1.GetDescription();
            var result2 = TestEnum.Value2.GetDescription();
            Assert.AreEqual("FirstValue", result1);
            Assert.AreEqual("SecondValue", result2);
        }
    }

    public enum TestEnum
    {
        [System.ComponentModel.Description("FirstValue")]
        Value1,
        [System.ComponentModel.Description("SecondValue")]
        Value2,
    }
}

