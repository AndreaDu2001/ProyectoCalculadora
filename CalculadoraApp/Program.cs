using System;
namespace CalculadoraApp
{
   public class Calculadora
    {
        public int Sumar(int valor1, int valor2) => valor1 + valor2;

    }
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculadora();
            Console.WriteLine($"2 + 3 {calc.Sumar(2,3)}");
        }
    }
}
