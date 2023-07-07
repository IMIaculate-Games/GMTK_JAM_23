using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Made by <see href="https://github.com/n-c0de-r" langword="n-c0de-r" />
/// </summary>
[CreateAssetMenu(fileName = "WaveData", menuName = "ScriptableObjects/Wave Data", order = 2)]
public class WaveData : ScriptableObject
{
    #region Serialize Fields

    //[SerializeField] private List<Mob> mobs;
    [SerializeField] private List<Wave> waves;

    #endregion

    #region Fields

    private List<GameObject> test;

    #endregion

    #region GetSets

    public bool IsEmpty { get => waves.Count == 0; }

    public int EnemyNumber { get => waves[0].EnemyNumber; /*set => enemyNumber = value;*/ }

    public Wave NextWave { get => waves[0]; /*set => mobs = value;*/ }

    #endregion
}
