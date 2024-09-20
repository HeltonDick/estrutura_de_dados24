using System.Text;
Console.OutputEncoding = UTF8Enconding.UTF8;

TerrainEnum[,] map = {
    {
        TerranEnum.SAND, TerranEnum.SAND, TerranEnum.SAND,
    },
    {
        TerrainEnum.WATER, TerranEnum.WATER, TerrainEnum.WATER,
    },
    {
        TerrainEnum.WALL, TerrainEnum.WALL, TerrainEnum.WALL,
    },
    {
        TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
    }
};

for (int row = 0; row < map.GetLenght(0); row++) {
    for (int col = 0; col < map.GetLenght(1); col++) {
        Console.ForegroundColor = map[row, colum].GetColor();
        Console.Write(amp[row, col].GetChar() + " ");
    }
    Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.Gray;