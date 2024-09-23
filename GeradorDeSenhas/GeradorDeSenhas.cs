 Console.Write("Digite o comprimento desejado da senha: ");
        int comprimento;
        
       
        while (!int.TryParse(Console.ReadLine(), out comprimento) || comprimento <= 0)
        {
            Console.Write("Por favor, insira um número válido maior que zero: ");
        }

        string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();
        char[] senha = new char[comprimento];

        for (int i = 0; i < comprimento; i++)
        {
            senha[i] = caracteres[random.Next(caracteres.Length)];
        }

        string senhaGerada = new string(senha);
        Console.WriteLine($"Senha gerada: {senhaGerada}");