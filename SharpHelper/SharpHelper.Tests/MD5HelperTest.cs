using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpHelper.Tests
{
    [TestClass]
    public class MD5HelperTest
    {
        [TestMethod]
        public void Will_Generate_A_Valid_MD5_Hash_Sucessfully()
        {
            var str = "My string to Encrypt";
            var hash = str.Md5Encypt();
            Assert.IsTrue(hash.IsValidMd5());
        }

        [TestMethod]
        public void Will_Not_Validate_MD5_Hash_Because_Its_Empty()
        {
            var str = string.Empty;
            Assert.IsFalse(str.IsValidMd5());
        }

        [TestMethod]
        public void Will_Not_Validate_MD5_Hash_Because_It_Has_Invalid_Characters()
        {
            var str = "000102030405060708090a0b0c0d0e0T";
            Assert.IsFalse(str.IsValidMd5());
        }

        [TestMethod]
        public void Will_Not_Validate_MD5_Hash_Because_The_Lenght_Is_Higher_Than_Valid_Hash()
        {
            var str = "000102030405060708090a0b0c0d0e01263541256431";
            Assert.IsFalse(str.IsValidMd5());
        }

        [TestMethod]
        public void Will_Not_Validate_MD5_Hash_Because_The_Lenght_Is_Lower_Than_Valid_Hash()
        {
            var str = "000102030405060708090a0b";
            Assert.IsFalse(str.IsValidMd5());
        }

        [TestMethod]
        public void Will_Validate_MD5_Hash()
        {
            var str = "000102030405060708090a0b0c0d0e0f";
            Assert.IsTrue(str.IsValidMd5());
        }
    }
}