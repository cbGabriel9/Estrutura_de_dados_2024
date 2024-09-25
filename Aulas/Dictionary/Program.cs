using System.Collections.Generic;


Dictionary<int, string> dict = new()
{
    {0, "Tomate"},
    {1, "Queijo"},
    {2, "Arroz"},
    {3, "Feijão"}


};

dict.Add(4, "Gabriel");
dict.Add(5, "Sophia");
dict.Add(6, "Ruby");

foreach (KeyValuePair<int, string> item in dict)
{
    Console.WriteLine("Key: {0} | Valor: {1}", item.Key, item.Value);
}
