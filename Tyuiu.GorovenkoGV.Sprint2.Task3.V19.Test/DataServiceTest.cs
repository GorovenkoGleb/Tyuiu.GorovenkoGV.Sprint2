using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorovenkoGV.Sprint2.Task3.V19.Lib;

namespace Tyuiu.GorovenkoGV.Sprint2.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(x);
            double wait = 17;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.556;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(x);
            double wait = 17;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -25;
            double res = ds.Calculate(x);
            double wait = -274.96;
            Assert.AreEqual(wait, res);

        }
    }
}
