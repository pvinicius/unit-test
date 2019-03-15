using Calculadora.Domain.IService;

namespace Calculadora.Domain.Service
{
    public class CalculadoraService : ICalculadoraService
    {
        public double Sum(double firstNumber, double secondNumber)
        {
            var result = firstNumber + secondNumber;

            //Simulando acesso ao banco de dados
            var accessed = AccessDataBase();

            return result;
        }
        private bool AccessDataBase() => true;
        public double Subtraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public double Division(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
        public double Multiplication(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
