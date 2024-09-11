List<double> numbers = [];

do
{
    Console.WriteLine("Informe um número");
    string? numberStr = Console.ReadLine();

    // Validando a entrada do usuário

    if (!double.TryParse(numberStr, out double number))
    
        break;
    
    numbers.Add(number);
    Console.WriteLine($"A média é de {numbers.Average()}");
} while (true);