using Calculadora.Domain.IService;

namespace Calculadora.Domain.Service
{
    public class CalculadoraService : ICalculadoraService
    {
        private bool Save(double value) => true;
        public double Sum(double firstNumber, double secondNumber)
        {
            //Aplicando regra de negócio
            var result = firstNumber + secondNumber;

            //Acesso ao banco de dados
            Save(result);

            return result;
        }
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
