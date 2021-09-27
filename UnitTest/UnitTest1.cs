using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPN;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void SimpleMinus()
        {
            Calculator calc = new Calculator("|3 2 -|");
            Assert.AreEqual(calc.Answer, 1);
        }
        [TestMethod]
        public void SimplePlus()
        {
            Calculator calc = new Calculator("|+ 9 2|");
            Assert.AreEqual(calc.Answer, 11);
        }
        [TestMethod]
        public void SimpleMultiply()
        {
            Calculator calc = new Calculator("|7 * 4|");
            Assert.AreEqual(calc.Answer, 28);
        }
        [TestMethod]
        public void SimpleDiv()
        {
            Calculator calc = new Calculator("|15 3 /|");
            Assert.AreEqual(calc.Answer, 5);
        }
        [TestMethod]
        public void SimpleDeg()
        {
            Calculator calc = new Calculator("|4 2 ^|");
            Assert.AreEqual(calc.Answer, 16);
        }
        [TestMethod]
        public void DifficultTest1()
        {
            Calculator calc = new Calculator("|4 2 5 + *|");
            Assert.AreEqual(calc.Answer, 14);
        }
        [TestMethod]
        public void DifficultTest2()
        {
            Calculator calc = new Calculator("|1 2 + 4 * 3 +|");
            Assert.AreEqual(calc.Answer, 15);
        }
        [TestMethod]
        public void DifficultTest3()
        {
            Calculator calc = new Calculator("|4 2 5 + * 4 - 8 +|");
            Assert.AreEqual(calc.Answer, 18);
        }
        [TestMethod]
        public void NoneRPN1()
        {
            Calculator calc = new Calculator("|2 + 2 * 2|");
            Assert.AreEqual(calc.Answer, 6);
        }
        [TestMethod]
        public void NoneRPN2()
        {
            Calculator calc = new Calculator("|2 + (2 * 2)|");
            Assert.AreEqual(calc.Answer, 6);
        }
        [TestMethod]
        public void NoneRPN3()
        {
            Calculator calc = new Calculator("|(5 * 5) * 2 / 2|");
            Assert.AreEqual(calc.Answer, 25);
        }
    }
}
