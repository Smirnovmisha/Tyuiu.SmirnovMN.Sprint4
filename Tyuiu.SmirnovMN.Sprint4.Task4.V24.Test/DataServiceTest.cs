using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint4.Task4.V24.Lib;

namespace Tyuiu.SmirnovMN.Sprint4.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] num = new int[5, 5]
            {
                { 7, 9, 7, 6, 7 },
                { 9, 9, 8, 6, 7 },
                { 8, 6, 5, 6, 7 },
                { 9, 9, 7, 8, 7 },
                { 5, 9, 9, 8, 9 }
            };
            int[,] res = ds.Calculate(num);
            int[,] wait = new int[5, 5]
            {
                { 7, 9, 7, 1, 7 },
                { 9, 9, 1, 1, 7 },
                { 1, 1, 5, 1, 7 },
                { 9, 9, 7, 1, 7 },
                { 5, 9, 9, 1, 9 }
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
