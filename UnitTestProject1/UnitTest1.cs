using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            int[] arr = new int[] {4, 0, 0, 0, 2, 1, 7, 0, 1, 0, 7 };
            
            int testNumber = 0;
            int expectedCount = 5;
            int realCount = NumberInArray.CountNum(arr, testNumber);
            Assert.AreEqual(expectedCount, realCount);
        }
    }
}
