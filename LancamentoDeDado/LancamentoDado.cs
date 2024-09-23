 Random random = new Random();
        string opcao;

        do
        {
            
            int resultado = random.Next(1, 7); 
            Console.WriteLine($"Resultado do lançamento do dado: {resultado}");

            
            Console.Write("Deseja lançar o dado novamente? (s/n): ");
            opcao = Console.ReadLine().ToLower();

        } while (opcao == "s");

        Console.WriteLine("Obrigado por jogar!");