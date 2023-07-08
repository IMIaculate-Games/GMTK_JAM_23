using UnityEngine;

public static class EnemyData
{
    private static readonly int initialLives = 10, initialGold = 100;
    private static int lives = initialLives, gold = initialGold;

    public static int Lives { get => lives; set => lives = Mathf.Clamp(value, 0, 10); }
    public static int Gold { get => gold; set => gold += value; }
}
