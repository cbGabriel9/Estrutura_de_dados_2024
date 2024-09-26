Dictionary<string, string> product = new()
{
    { "A1", "Tomato"},
    { "A2", "Lettuce"},
    { "A3", "Broccoli"},
    { "A4", "Carrot"},
    { "A5", "Avocado"},

    { "B1", "Ice tea"},
    { "B2", "Soda"},
    { "B3", "Water"},
    { "B4", "Milk"},
    { "B5", "Coffee"},
    { "B6", "51"},

    { "C1", "Candy"},
    { "C2", "Chocolate"},
    { "C3", "Churro"},
    { "C4", "Gingerbread"},
    { "C5", "Ice cream"},
    { "C6", "Candy"},
    { "C7", "Chocolate"},
    { "C8", "Churro"},
    { "C9", "Gingerbread"}
};

System.Console.WriteLine("Olá produtor(a), digite aqui o código do produto que deseja encontrar.");

string? answer = Console.ReadLine();

System.Console.WriteLine(product.ContainsValue(answer));