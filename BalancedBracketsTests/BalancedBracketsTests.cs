using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(" "));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("a"));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[a]"));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[a][]"));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[L[a]unch[Code]]"));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[ [ [] ] [] ]"));
            
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]a]["));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[La[unch][Code]"));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]Launch][Code[]"));

        }
    }
}
