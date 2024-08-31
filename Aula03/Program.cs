/* int[] numbers;
numbers = new int[5];

// Atribuição de valor direta
// ao índice do vetor
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

//Declaração inicializada

string[] names =
    {"Eu", "Tu", "Ele", "Nós", "Vós", "Eles"};

//Exemplo Vetor com os nomes dos meses

string[] months = new string[12];
for (int i = 0; i <= 12; i++)
{
    DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);

    string name = firstDay.ToString("MMMMM");

    months[i-1] = name;
}

foreach(string m in months)
{
    Console.WriteLine(m);
} */

//--------------------------------Atividade--------------------------------//
/* Escreva um algoritmo que armazene em dois vetores separados os primeiros 100 números pares e ímpares. 
No final, imprima a sequência armazenada em cada um deles. */

int[] num_par = new int[201]; // Armazenando os valores pares
int[] num_impar = new int[201]; // Armazenando os valores pares

Console.WriteLine("Os números pares armazenados são:");

for (int i = 0; i <= 200; i++){
    if (i % 2 == 0){
        num_par[i] = i;
        Console.WriteLine(i); // Utilizando a função para saber o resto da divisão, caso for zero, o número é par
        
    }
}

Console.WriteLine("Os números ímpares armazenados são:");

for (int i = 0; i <= 200; i++){
    if (i % 2 != 0){
        num_impar[i] = i;
        Console.WriteLine(i); // Utilizando a função para saber o resto da divisão, caso for diferente zero, o número é ímpar
    }
}
