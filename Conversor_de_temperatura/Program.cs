

        Console.WriteLine("Conversor de Temperatura");
        Console.WriteLine("Escolha a unidade de origem:");
        Console.WriteLine("1 - Celsius");
        Console.WriteLine("2 - Fahrenheit");
        Console.WriteLine("3 - Kelvin");
        
        int escolha = int.Parse(Console.ReadLine());
        
        Console.Write("Digite a temperatura: ");
        double temperatura = double.Parse(Console.ReadLine());

        if (escolha == 1) // Celsius
        {
            double fahrenheit = (temperatura * 9 / 5) + 32;
            double kelvin = temperatura + 273.15;
            Console.WriteLine(temperatura + " °C = " + fahrenheit + " °F");
            Console.WriteLine(temperatura + " °C = " + kelvin + " K");
        }
        else if (escolha == 2) // Fahrenheit
        {
            double celsius = (temperatura - 32) * 5 / 9;
            double kelvin = celsius + 273.15;
            Console.WriteLine(temperatura + " °F = " + celsius + " °C");
            Console.WriteLine(temperatura + " °F = " + kelvin + " K");
        }
        else if (escolha == 3) // Kelvin
        {
            double celsius = temperatura - 273.15;
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine(temperatura + " K = " + celsius + " °C");
            Console.WriteLine(temperatura + " K = " + fahrenheit + " °F");
        }
        else
        {
            Console.WriteLine("Escolha inválida.");
        }
    