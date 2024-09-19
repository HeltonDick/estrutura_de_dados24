public enum TerrainEnum {
    GRASS,
    SAND,
    WATER,
    WALL
};

public static class TerrainEnumExtensions {
    public static ConsoleColor GetColor(this TerrainEnum terrain) {
        switch (terrain) {
            case TerrainEnum.GRASS: return Console.Color.Green;
            case TerrainEnum.SAND: return Console.Color.Yellow;
            case TerrainEnum.WATER: return Console.Color.Blue;
            default: return Console.Color.DarkGray;
        }
    }

    public static char GetChar(this TerrainEnum terrain) {
        switch(terrain) {
            case TerrainEnum.GRASS: return '\u201c';
            case TerrainEnum.SAND: return '\u25cb';
            case TerrainEnum.WATER: return '\u2248';
            default: return '\u25cf';
        }
    }
}