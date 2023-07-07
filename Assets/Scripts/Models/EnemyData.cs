using UnityEngine;

/// <summary>
/// Made by <see href="https://github.com/n-c0de-r" langword="n-c0de-r" />
/// </summary>
[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/Enemy Data", order = 2)]
public class EnemyData : ScriptableObject
{
    #region Fields

    [SerializeField] [Range(1, 10)] private int lives = 10;
    [SerializeField] [Range(100, 1000)] private int gold = 100;

    #endregion

    #region GetSets

    public int Lives { get => lives; set => lives = value; }
    public int Gold { get => gold; set => gold = value; }

    #endregion
}
