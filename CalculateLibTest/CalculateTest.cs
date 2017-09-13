using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLib.Test
{
    [TestClass]
    public class CalculateTest
    {
        private Calculate calculateObj;
        private List<int[]> valueList;

        public CalculateTest()
        {
            calculateObj = new Calculate();
        }

        [TestInitialize]
        public void TestInit()
        {
            valueList = new List<int[]>();
            int[] values1 = new int[] { 5, 9, 3 };
            int[] values2 = new int[] { 9, 5, 3 };
            int[] values3 = new int[] { 3, 9, 5 };
            int[] values4 = new int[] { -5, -9, -3 };
            int[] values5 = new int[] { -5, 0, -3 };
            int[] values6 = new int[] { 6 };
            int[] values7 = null;
            valueList.Add(values1);
            valueList.Add(values2);
            valueList.Add(values3);
            valueList.Add(values4);
            valueList.Add(values5);
            valueList.Add(values6);
            valueList.Add(values7);
        }

        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void GetMaxTest()
        {
            int actualVal =calculateObj.GetMax(valueList[0]);
            Assert.AreEqual(9, actualVal);
            actualVal = calculateObj.GetMax(valueList[1]);
            Assert.AreEqual(9, actualVal);
            actualVal = calculateObj.GetMax(valueList[2]);
            Assert.AreEqual(9, actualVal);
            actualVal = calculateObj.GetMax(valueList[3]);
            Assert.AreEqual(-3, actualVal);
            actualVal = calculateObj.GetMax(valueList[4]);
            Assert.AreEqual(0, actualVal);
            actualVal = calculateObj.GetMax(valueList[5]);
            Assert.AreEqual(6, actualVal);
            calculateObj.GetMax(valueList[6]);
        }
    }
}