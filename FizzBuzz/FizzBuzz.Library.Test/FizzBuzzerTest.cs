using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz.Library.Test
{
    [TestFixture]
    public class FizzBuzzerTest
    {
        [Test]
        public void Buzzer_When_ReturnsInput([Values(1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19)] int input)
        {
            //Act
            string output = FizzBuzzer.Getvalue(input);

            //Assert
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_WhenDiv3_ReturnsFizz([Values(3, 6, 9, 12, 18)] int input)
        {
            //Act
            string output = FizzBuzzer.Getvalue(input);

            //Assert
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_When5_ReturnsBuzz([Values(5, 10, 20)]int input)
        {
            //Act
            string output = FizzBuzzer.Getvalue(input);

            //Assert
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_WhenDiv3AndDiv5_ReturnsFizzBuzz([Values(15)] int input)
        {
            //Act
            string output = FizzBuzzer.Getvalue(input);

            //Assert
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
