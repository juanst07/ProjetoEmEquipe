 List<string> opcoes = new List<string>()
        {
            "Restaurante Italiano - Lasanha",
            "Sushi Bar - Sushi e Sashimi",
            "Churrascaria - Picanha",
            "Restaurante Vegetariano - Salada de Quinoa",
            "Hamburgueria - Cheeseburger",
            "Pizzaria - Pizza de Calabresa",
            "Comida Árabe - Esfirra e Kibe",
            "Restaurante Mexicano - Tacos"
        };

        Console.WriteLine("Você gostaria de:");
        Console.WriteLine("1 - Escolher um restaurante ou prato");
        Console.WriteLine("2 - Deixar o sistema escolher aleatoriamente");
        Console.Write("Digite sua escolha (1 ou 2): ");
        string escolha = Console.ReadLine();

        if (escolha == "1")
        {
            Console.WriteLine("Aqui estão suas opções de restaurantes/pratos:\n");
            for (int i = 0; i < opcoes.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {opcoes[i]}");
            }

            Console.Write("\nDigite o número da sua escolha: ");
            int opcaoEscolhida;

            while (!int.TryParse(Console.ReadLine(), out opcaoEscolhida) || opcaoEscolhida < 1 || opcaoEscolhida > opcoes.Count)
            {
                Console.Write("Escolha inválida. Por favor, digite um número válido: ");
            }
            Console.WriteLine($"\nVocê escolheu: {opcoes[opcaoEscolhida - 1]}");
        }
        else if (escolha == "2")
        {
            Random random = new Random();
            int opcaoAleatoria = random.Next(opcoes.Count);
            Console.WriteLine($"\nO sistema escolheu: {opcoes[opcaoAleatoria]}");
        }
        else
        {
            Console.WriteLine("Opção inválida. Encerrando o programa.");
        }
