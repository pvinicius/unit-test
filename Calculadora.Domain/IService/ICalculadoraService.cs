namespace Calculadora.Domain.IService
{
    public interface ICalculadoraService
    {
        double Sum(double firstNumber, double secondNumber);
        double Subtraction(double firstNumber, double secondNumber);
        double Division(double firstNumber, double secondNumber);
        double Multiplication(double firstNumber, double secondNumber);
    }
}
