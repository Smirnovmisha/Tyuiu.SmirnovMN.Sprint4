using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint4.Task7.V4.Lib;

namespace Tyuiu.SmirnovMN.Sprint4.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "382976421897";
            int[,] res = { { 3, 8, 2, 9 }, { 7, 6, 4, 2 }, { 1, 8, 9, 7 } };
            Assert.AreEqual(ds.Calculate(3, 4, str), 36);
        }
    }
}