// Criando um vetor multidimencional
// Com 5 linhas e duas colunas
int [,] numbers = new int[5,2];

// Criando um vetor tridumencional
int [,,] triNumbers = new int [5,4,3];

// Podemos inicializar os valores do vetor no momento de sua declaração
int [,] iniNumbers = new int [,] {
    {1,2,3},
    {4,5,6},
    {7,8,9},
    {10,11,12},
    {-1,-2,-3},
};

// Para acessar os valores contidos neste tipo de variavel 
int value = iniNumbers[0,1]; // Neste caso = 15

Console.WriteLine($"iniNumbers[0,1] == {value}");