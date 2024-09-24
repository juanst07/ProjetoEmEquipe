using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de IMC (Índice de Massa Corporal)");

        Console.Write("Digite seu peso em kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite sua altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        // Calculando o IMC
        double imc = peso / (altura * altura);

        Console.WriteLine("Seu IMC é: " + imc);

        // Categorias de IMC
        if (imc < 18.5)
        {
            Console.WriteLine("Categoria: Baixo peso");
        }
        else if (imc >= 18.5 && imc < 24.9)
        {
            Console.WriteLine("Categoria: Peso normal");
        }
        else if (imc >= 25 && imc < 29.9)
        {
            Console.WriteLine("Categoria: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Categoria: Obesidade");
        }
    }
}
