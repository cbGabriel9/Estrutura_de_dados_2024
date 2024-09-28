using System.ComponentModel;

Dictionary<string, string> product = new()
{
    // Prateleira 1
    { "#001", "A1"},
    { "#002", "A2"},
    { "#003", "A3"},
    { "#004", "A4"},

    // Prateleira 2
    { "#005", "A5"},
    { "#010", "B1"},
    { "#011", "B2"},
    { "#012", "B3"},

    // Prateleira 3    
    { "#013", "B4"},
    { "#014", "B5"},
    { "#015", "B6"},
    { "#100", "C1"},
    
    // Prateleira 4
    { "#101", "C2"},
    { "#102", "C3"},
    { "#103", "C4"},
    { "#104", "C5"},

    // Prateleira 5
    { "#105", "C6"},
    { "#106", "C7"},
    { "#107", "C8"},
    { "#108", "C9"}
};

System.Console.WriteLine("Olá produtor(a), digite aqui o código do produto que deseja encontrar.");

string? answer = Console.ReadLine();


try
{
    System.Console.WriteLine($"O seu produto está na prateleira: {product[answer!]}");
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu um erro:");
    Console.WriteLine(ex.Message);
}

