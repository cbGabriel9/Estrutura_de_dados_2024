using System.Collections;

// Utilizando a Lista Simples
ArrayList arrList = [];
arrList.Add(5);
arrList.Add("Gabriel");

// É possível adicionar um conjunto de valores de uma só vez

arrList.AddRange(new int [] {1,2,3});

//O método .Add() insere o valor ao final do vetor

arrList.Insert(1, 15);

//Já o método insert, me permite incluir o valor desejado na posição especificada no primeiro parâmetro. O .Insert empurra todos os valores para uma posição a mais e adiciona o valor naquela posição

// Lendo valores da lista
object primeiro = arrList[0]!; // O "!" indica que o valor vai ser nulo
int quarto = (int)arrList[3]!;

// Percorrendo a Lista com foreach

foreach (object obj in arrList)
{
    Console.WriteLine($" | {obj}");
}

// Com o ".Count" se obtém o tamanho total da lista

int tamanho = arrList.Count;

// ".Capacity" retorno a capacidade de quantos números podem ser retornados

int capacidade = arrList.Capacity;

Console.WriteLine(tamanho);
Console.WriteLine(capacidade);

// Percorre a lista
for(int i = 0; i < arrList.Count; i++)
{
     Console.WriteLine( $" | {arrList[i]}");
}
List<int> testList = [];

// Recursos importantes da lista
// Verificar se um valor é contido na lista

bool contemNome = arrList.Contains("Gabriel");
if(!contemNome)
    Console.WriteLine("Nome Gabriel não encontrado");

// Para saber o índice que contém o valor buscado. Neste caso se o valor existir na lista, retorna o posição do índice (número inteiro). Caso o valor não exista na lista, retorna -1

int indiceDoValor = arrList.IndexOf("Gabriel");
if(indiceDoValor >= 0)
    Console.WriteLine($"Gabriel está em: [{indiceDoValor}]");
else
    Console.WriteLine("Realmente não tem Gabriel escrito");


// É possível também remover itens da lista

arrList.Remove("Gabriel"); // Remove pelo valor
arrList.RemoveAt(0); // Remove pelo índice
arrList.RemoveRange(0,1); // O primeiro parâmetro é o índice e o segundo é quantos itens após o índice