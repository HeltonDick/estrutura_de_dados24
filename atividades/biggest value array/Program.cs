
/* Podemos inicializar os valores do vetor no momento de sua declaração
int [,] iniNumbers = new int [,] {
    {1,2,3},
    {4,5,6},
    {7,8,9},
    {10,11,12},
    {-1,-2,-3},
};
*/

int biggestNumber = 0;
int line;
int colum;

int [,] iniNumbers = new int [,] {
    {1,2,3},
    {4,5,6},
    {7,8,9},
    {10,11,12},
    {-1,-2,-3},
};

for(int i = 0; i < 5; i ++){
    for(int j = 0; j < 3; j++) {
        if (iniNumbers[i, j] > biggestNumber) {
            biggestNumber = iniNumbers[i, j];
            line = iniNumbers[i];
            colum = iniNumbers[j];
        };
    };
};

Console.WriteLine($"O maior valor é {biggestNumber}");
Console.WriteLine($"A linha do maior numero é {line} e a coluna {colum}");