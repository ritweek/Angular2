using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorOpTest
    {
        [TestMethod]
        public void Should_AddFiveAndFour_ReturnNine()
        {
            //Arrange
            CalculatorOp sut = new CalculatorOp();

            //Act
            int result = sut.Add(5, 4);
            //Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Should_MulFiveAndFour_ReturnTwenty()
        {
            //Arrange
            CalculatorOp sut = new CalculatorOp();

            //Act
            int result = sut.Mul(5, 4);
            //Assert
            Assert.AreEqual(20, result);
        }
    }
}
