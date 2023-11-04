using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint4.Task2.V28.Lib;

namespace Tyuiu.SmirnovMN.Sprint4.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 7, 6, 3, 8, 5, 7, 6, 7, 6, 5, 4, 8 };
            int res = ds.Calculate(array);
            int wait = 34;
            Assert.AreEqual(wait, res);
        }
    }
}
