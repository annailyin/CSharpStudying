using Microsoft.VisualStudio.TestTools.UnitTesting;
using IT;

namespace ITCompanyTests
{
    [TestClass]
    public class EnglishSymbolsTests
    {
        [TestMethod]
        public void EnglishSymbolACapitalPositive()
        {
            bool result = SymbolsChecker.IsEnglishSymbol('A');
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EnglishSymbolZCapitalPositive()
        {
            bool result = SymbolsChecker.IsEnglishSymbol('Z');
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EnglishSymbolaSmallPositive()
        {
            bool result = SymbolsChecker.IsEnglishSymbol('a');
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EnglishSymbolzSmallPositive()
        {
            bool result = SymbolsChecker.IsEnglishSymbol('z');
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NotEnglishSymbolNegative()
        {
            bool result = SymbolsChecker.IsEnglishSymbol(' ');
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DigitSymbolNegative()
        {
            bool result = SymbolsChecker.IsEnglishSymbol('3');
            Assert.IsFalse(result);
        }
    }
}
