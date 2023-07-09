public static class GameData
{
    private static readonly int initialLives = 10, initialGold = 100;
    public static int enemyLives = initialLives, enemyGold = initialGold;
    public static int life = initialLives * 2, gold = initialGold;
    public static bool isPaused = false, isRunning = false;
    public const int MAIN_MENU = 0, LEVEL1 = 1, LEVEL2 = 2, LEVEL3 = 3, GAME_OVER = 4;
}
