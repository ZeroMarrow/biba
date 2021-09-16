using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using biba;

namespace boba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] readyBinom = new int[] {1,9,36,84,126,126,84,36,9,1 };
            int[] myBinom = biba.Program.Lox(9);
            CollectionAssert.AreEqual(readyBinom, myBinom);
        }
    }
}
