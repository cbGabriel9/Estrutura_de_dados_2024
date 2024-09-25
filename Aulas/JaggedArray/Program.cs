// JegueArray é o array do Ceará
// JaggedArray é também conhecido como um vetor de vetores

int [][] numbers = new int[4][];

//Nesse caso [][] indica que é um vetor de vetores. Neste exemplo um vetor de 4 posições contendo vetores de tamanho indefinido
numbers[0] = new int[] {1, 2, 3};
numbers[1] = new int[] {4, 3, 2, 1};
numbers[2] = new int[] {1,2, 0};
numbers[3] = new int[] {57};
numbers[4] = null!;

// Para obter valor de JaggedArray
int valor = numbers[0][2];

Console.WriteLine(numbers[1][2]);