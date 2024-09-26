using System.Collections.Generic;
using Dictionary;


// Diferente da HashTable, o Dictionary nos permite especificar o tipo de dado que será utilizado nos pares Key e Value, isso nos fornece uma estrutura fortemente tipada

Dictionary<string, string> secretMembers = new()
{
    {"1", "Dani do bumbum guloso"},
    {"2", "Igor das tripa saltada"},
    {"3", "Thiago pé quente"}
};

string var = secretMembers["3"];

// Tratamento de erros

try
{
    var = secretMembers["4"];
}
catch (Exception ex)
{
    System.Console.WriteLine("Erro ao obter valor do quarto");
    System.Console.WriteLine(ex.Message);
}

if (secretMembers.ContainsKey("1"))
{
    System.Console.WriteLine($"Chave 1: {secretMembers["1"]}");
}

// Outra forma de obter o valor e evitar o erro

secretMembers.TryGetValue("4", out string? valor);
if (valor is not null)
{
    System.Console.WriteLine($"Chave 2: {valor}");
}

// Podemos adicionar da mesma forma pela chave inexistente

secretMembers["0"] = "Ninguém";

// Percorrer o dicionário

foreach (KeyValuePair<string, string> members in secretMembers)
{
    System.Console.WriteLine($"{members.Key}:{members.Value}");
}

Dictionary<int, Person> secretPerson = new();

secretPerson.Add(1, new Person(){
    Name = "Gabriel Ceron Bianchi",
    Id = 0,
    BirthDate = new DateTime(2004, 7, 16)
}
);

secretPerson.Add(2, new Person(){
    Name = "Thiaguera das Cruzes",
    Id = 1,
    BirthDate = new DateTime(2005, 3, 31)
}
);

secretPerson.Add(3, new Person(){
    Name = "Marcola foguete não tem ré",
    Id = 2,
    BirthDate = new DateTime(2005, 2, 4)
}
);

foreach (KeyValuePair<int, Person> item in secretPerson)
{
    System.Console.WriteLine(item.Key);
    System.Console.WriteLine(item.Value.Id);
    System.Console.WriteLine(item.Value.Name);
    System.Console.WriteLine(item.Value.BirthDate);



}