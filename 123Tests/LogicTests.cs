using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CubeNoEqualTest_1_0_1()
        {
            int a = 1;
            int b = 0;
            int expected = 1;
            Logic logic = new Logic();
          
            var actual = logic.CubeNoEqual(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CubeNoEqualTest_minus1_0_minus100()
        {
            int a = -1;
            int b = 0;
            int expected = -100;
            Logic logic = new Logic();

            var actual = logic.CubeNoEqual(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CubeAreEqualTest()
        {
            int a = 1;
            int b = 1;
            int expected = 1;
            Logic logic = new Logic();

            var actual = logic.CubeAreEqual(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CubeAreEqualTest_nekorect()
        {
            int a = 1;
            int b = -1;
            int expected = -100;
            Logic logic = new Logic();

            var actual = logic.CubeAreEqual(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}