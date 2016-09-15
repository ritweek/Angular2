using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator1;
using NUnit.Framework;
using NUnit.Util;


namespace Calculator.NUnitTest
{
    [TestFixture]
    public class CalculatorOpTest
    {
        [Test]
        public void Should_AddFiveAndFour_ReturnNine()
        {
            //Arrange
            CalculatorOp sut = new CalculatorOp();
            string path = Path.GetFullPath("~");

            //Act
            int result = sut.Add(5, 4);
            //Assert
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void Should_MulFiveAndFour_ReturnTwenty()
        {
            //Arrange
            CalculatorOp sut = new CalculatorOp();

            //Act
            int result = sut.Mul(5, 4);
            //Assert
            Assert.That(result, Is.EqualTo(20));
        }
    }
}
