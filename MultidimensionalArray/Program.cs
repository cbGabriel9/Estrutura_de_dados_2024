// Criando um vetor multidimensional
// com 5 linhas e 2 colunas

int[,] numbers = new int[5,2];

// Criando um vetor tridimensional

int[,,] triNumbers = new int[5,4,3];

// Podemos Inicializar os valores do vetor no momento de sua declaração

int[,] iniNumbers = new int[,] 
    {
    {9,5,-9},
    {4,2,-7},
    {8,7,-5},
    {7,7,7},
    };

    // Para acessar os valores contido neste tipo de variável
    // tipo de variável

    int valor = iniNumbers[0,1]; // Neste caso, posição = 5
    int maiorNum = 0;

   for(int coluna = 0; coluna < iniNumbers.GetLength(0); coluna++)
   {
    for (int linha = 0; linha < iniNumbers.GetLength(1); linha++)
    {
        if (iniNumbers[coluna,linha] > maiorNum)
        {
            maiorNum = iniNumbers[coluna,linha];
        }
    }
   }

    Console.WriteLine(maiorNum);