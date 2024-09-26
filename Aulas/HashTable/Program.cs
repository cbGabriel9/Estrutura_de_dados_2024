// Exemplo de um caderno de pessoas e qualidades
using System.Collections;

Hashtable QualityBook = new Hashtable()
{
    { "Lindo" , "Gabriel" },
    { "Carismática" , "Sophia" },
    { "Famosa" , "Isabella" },
    {"Esquisito", "Vinizão"},
    { "Fiel" , "Thiaguera" },
    {"Tripa Seca", "Igor"},
    {"Narcisista", "Dani"},
    {"Gigante", "Maurício"}
};

// Formas de adicionar na HashTable

QualityBook.Add("Gui", "Bicicletero");

QualityBook["Estourada"] = "Gustavo";

// A HashTable verifica se há duplicidade de chave e pode lançar uma exception

try
{
    QualityBook.Add("Lindo", "Gabriel");
} catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Gabriel já é o mais lindo, acalma");
    throw ex;
}

// Percorrendo itens da HashTable

if (QualityBook.Count == 0)
{
    System.Console.WriteLine("A agenda está vazia");
} else{
    foreach (DictionaryEntry entry in QualityBook)
    {
        System.Console.WriteLine($"{entry.Key}:{entry.Value}");
    }
}