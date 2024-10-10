using Teste;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
//                  Criação de objeto da classe e Pegando valor do usuário
// Person person = new();

// System.Console.WriteLine("Qual seu nome?");
// person.Name = Console.ReadLine()!;

// string[] names = new string[3];
// int[,] numbers = new int[3, 3];

// names[0] = "João";
// names[1] = "Mariana";
// names[2] = "Pedrinho";


//                    Iteração dos arrays bidimensionais

// for (int r = 0; r < 3; r++)
// {
//     for (int c = 0; c < 3; c++)
//     {
//         numbers[r, c] = 10;
//         System.Console.Write(numbers[r, c]);
//         if (c == 2)
//         {
//             System.Console.WriteLine("/");
//         }
//     }
// }
// person.Talk();


//                            Função Random
// Random random = new();

// int numeroAleatorioIntervalo = random.Next(10, 51); // Valor mínimo e máximo
// Console.WriteLine("Número aleatório entre 10 e 50: " + numeroAleatorioIntervalo);

int[] vetor1 = new int[] {1, 2, 3};


//IndeOf (Retorna o índice do valor especificado)
System.Console.WriteLine("IndexOf");
int indice1 = Array.IndexOf(vetor1, 2);
System.Console.WriteLine(indice1);


//Reverse (Inverte a ordem dos valores no array)

System.Console.WriteLine("Reverse");

Array.Reverse(vetor1);

foreach(int item in vetor1)
{
    System.Console.WriteLine(item);
}


//Sort (Coloca os valores dentro do array em forma crescente)
Array.Sort(vetor1);
foreach(int item in vetor1)
{
    System.Console.WriteLine(item);
}

// Método de soma

int v1, v2;

v1 = Convert.ToInt32(Console.ReadLine());
v2 = Convert.ToInt32(Console.ReadLine());

Métodos.soma(v1, v2);

int[] array = new int[5];

array[4] = 2;

System.Console.WriteLine(array[4]);