using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogicTests
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        [DataRow("555-55-5555")]
        [DataRow("555555555")]
        [DataRow("547821693")]
        [DataRow("428-52-1234")]
        public void IsValidSsn_ValidInput_ReturnTrue(string input)
        {
            //TODO: Test the IsValidSSN method in the Validator class
            var result = Validator.IsSsn(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("A")]
        [DataRow("123-123-123")]
        [DataRow("1234567890")]
        [DataRow("TenLetters")]
        public void IsValidSsn_InvalidInput_ReturnsFalse(string input)
        {
            //TODO: Test the IsValidSSN method in the Validator class
            var result = Validator.IsSsn(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow(10, 1, 10)] //max boundary
        [DataRow(1, 1, 10)] //min boundary
        [DataRow(5, 1, 10)]
        [DataRow(2000, 0, 50000)]
        public void IsWithinRange_NumInInclusiveRange_ReturnTrue(int test, int min, int max)
        {
            //TODO: Test the IsWithinRange method in the Validator class
            var result = Validator.IsWithinRange(test, min, max);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(4, 5, 10)]
        [DataRow(11, 1, 10)]
        [DataRow(10000, 0, 5000)]
        public void IsWithinRange_NumOutsideInclusiveRange_ReturnsFalse(int test, int min, int max)
        {
            //TODO: Test the IsWithinRange method in the Validator class
            var result = Validator.IsWithinRange(test, min, max);
            Assert.IsFalse(result);
        }
    }
}
