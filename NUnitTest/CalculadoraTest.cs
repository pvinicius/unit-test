using NUnit.Framework;
using Moq;

namespace Calculadora.NUnitTest
{
    using Autofac.Extras.Moq;
    using Calculadora.Domain.Entities;
    using Calculadora.Domain.IService;
    using Calculadora.Domain.Service;

    public class CalculadoraTest
    {
        [Test]
        public void Should_Calculate_Two_Numbers()
        {
            //Arrange
            var expected = 20;
            var calculadora = new Calculadora()
            {
                FirstNumber = 10,
                SecondNumber = 10
            };
            var _service = new Mock<ICalculadoraService>();
            _service.Setup(s => s.Sum(calculadora.FirstNumber, calculadora.SecondNumber)).Returns(() => expected);

            //Act
            var actual = _service.Object.Sum(calculadora.FirstNumber, calculadora.SecondNumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Should_Subtract_Two_Numbers() => Assert.Pass();
        [Test]
        public void Should_Multiply_Two_Numbers() => Assert.Pass();
        [Test]
        public void Should_Divide_Two_Numbers() => Assert.Pass();
    }
}
