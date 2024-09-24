using Teste;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

// Person person = new();

// System.Console.WriteLine("Qual seu nome?");
// person.Name = Console.ReadLine()!;

// string[] names = new string[3];
// int[,] numbers = new int[3, 3];

// names[0] = "João";
// names[1] = "Mariana";
// names[2] = "Pedrinho";


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

Random random = new();

int numeroAleatorioIntervalo = random.Next(10, 51);
Console.WriteLine("Número aleatório entre 10 e 50: " + numeroAleatorioIntervalo);

