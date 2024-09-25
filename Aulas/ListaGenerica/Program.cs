using ListaGenerica;

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

// -- Lista de Pessoas 

List<Person> people = [];

Person p1 = new Person();

// Primeira Forma
p1.Name = "Thiaguinho filipense";
p1.Age = 12;
p1.Country = CountryEnum.PY;
people.Add(p1);

p1.Name = "Thiaguinho Filipense";

// Segunda Forma
people.Add(new Person(){
    Name = "Maumau Gorilinha",
    Age = 60,
    Country = CountryEnum.IT 
});

Person p3 = new Person(){
    Name = "Gusta Silva pé aquecido",
    Age = 54,
    Country = CountryEnum.JP
};

people.Add(p3);

// Formas de percorrer a Lista Genérica

// Usando foreach

foreach(Person p in people)
    {
        Console.WriteLine(p.Name);
    }

// Modo tradicional com o for

for (int i = 0; i < people.Count; i++)

    Console.WriteLine($"Nome: {people[i].Name}");

