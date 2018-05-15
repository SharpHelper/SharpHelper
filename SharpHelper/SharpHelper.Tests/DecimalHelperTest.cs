using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpHelper.Tests
{
    [TestClass]
    public class DecimalHelperTest
    {
        [TestMethod]
        public void Will_Return_True_Because_Number_Has_A_Decimal_Value()
        {
            decimal value = 10.65M;
            Assert.IsTrue(value.HasDecimal());
        }

        [TestMethod]
        public void Will_Return_False_Because_Number_Doesnt_Has_A_Decimal_Value()
        {
            decimal value = 10M;
            Assert.IsFalse(value.HasDecimal());
        }

        [TestMethod]
        public void Will_Return_The_Integer_Part_Of_A_Decimal_Value_With_Decimal_Value()
        {
            decimal value = 10.65M;
            Assert.AreEqual(10, value.GetIntPart());
        }

        [TestMethod]
        public void Will_Return_The_Integer_Part_Of_A_Decimal_Value_Without_Decimal_Value()
        {
            decimal value = 10M;
            Assert.AreEqual(10, value.GetIntPart());
        }

        [TestMethod]
        public void Will_Return_The_Number_Without_Increment()
        {
            decimal value = 10M;
            Assert.AreEqual(10, value.GetIntPart());
        }

        [TestMethod]
        public void Will_Return_The_Number_With_Increment()
        {
            decimal value = 10.65M;
            Assert.AreEqual(11, value.CalculateNumberPage());
        }
    }
}
