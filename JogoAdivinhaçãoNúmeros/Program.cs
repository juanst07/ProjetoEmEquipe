// See https://aka.ms/new-console-template for more information
using System;

namespace JogoAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numeroSecreto = random.Next(1, 101); // Número aleatório entre 1 e 100
            int palpite = 0;
            int tentativas = 0;

            Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
            Console.WriteLine("Eu pensei em um número entre 1 e 100. Tente adivinhar!");

            // Loop até que o usuário acerte
            while (palpite != numeroSecreto)
            {
                Console.Write("Digite seu palpite: ");
                palpite = Convert.ToInt32(Console.ReadLine());
                tentativas++;

                if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número é maior! Tente novamente.");
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O número é menor! Tente novamente.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você acertou o número {numeroSecreto} em {tentativas} tentativas.");
                }
            }
        }
    }
}
