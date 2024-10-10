using System.Reflection.Metadata;
using AtvOrdenacao;

string[] names = new string[3]{"Gabriel", "Amanda", "Thiago"};

AtvOrdenacao.InsertionSort.Sort(names);

foreach(string name in names)
    System.Console.WriteLine(name);