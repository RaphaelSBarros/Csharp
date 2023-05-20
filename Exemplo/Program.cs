using System;

namespace Exemplo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Novo Exemplo");
            Console.WriteLine("Digite um numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = Somar(numero1, numero2);
            Console.WriteLine(resultado);

            
        }

        static int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
