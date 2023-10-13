using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShustovTS.Sprint2.Task5.V6.Lib;
namespace Tyuiu.ShustovTS.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();
            int m = 2;
            int k = 11;
            string res = ds.FindCardNameAndValue(m, k);
            string wait = "Валет трефы";
            Assert.AreEqual(wait, res);
        }
    }
}
