using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint4.Task0.V6.Lib;

namespace Tyuiu.SmirnovMN.Sprint3.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();

            int[] nums = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            int res = dataService.GetMultOddArrEl(nums), wait = 52;
            Assert.AreEqual(wait, res);
        }
    }
}
