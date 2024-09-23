// See https://aka.ms/new-console-template for more information
using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a calculadora!");

            Console.Write("Digite o primeiro numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a operacao (+, -, *, /): ");
            char operacao = Console.ReadLine()[0];

            double resultado;

            switch (operacao)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    // Verificar divisao por zero
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Erro: Divisao por zero!");
                        return;
                    }
                    resultado = numero1 / numero2;
                    break;
                default:
                    Console.WriteLine("Operacao invalida!");
                    return;
            }

            // Exibir o resultado
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
