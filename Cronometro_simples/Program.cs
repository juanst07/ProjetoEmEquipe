using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número de segundos para o cronômetro: ");
        if (int.TryParse(Console.ReadLine(), out int segundos) && segundos > 0)
        {
            Console.WriteLine($"Iniciando o cronômetro para {segundos} segundos...");
            for (int i = segundos; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Tempo restante: {i} segundos");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Tempo esgotado!");
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido de segundos.");
        }
    }
}
