using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Base64Utilities.Tests
{
    [TestClass]
    public class StringUtilityTests
    {
        [TestMethod]
        public void FindInvalidBase64Characters_InvalidCharacterFound()
        {
            var testString = "Abadi/+123802tupdasfeio(jifeoapfjigeses9999873";
            var invalidCharacters = StringUtility.FindInvalidBase64Characters(testString);

            Assert.IsTrue(invalidCharacters.Length == 1);
            Assert.IsTrue(invalidCharacters[0].Equals('('));
        }

        [TestMethod]
        public void FindInvalidBase64Characters_InvalidCharactersNotFound()
        {
            var testString = "Abadi/+123802tupdasfeiojifeoapfjigeses9999873";
            var invalidCharacters = StringUtility.FindInvalidBase64Characters(testString);

            Assert.IsTrue(invalidCharacters.Length == 0);
        }
    }
}
