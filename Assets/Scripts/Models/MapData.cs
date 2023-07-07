using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Made by <see href="https://github.com/n-c0de-r" langword="n-c0de-r" />
/// </summary>
[CreateAssetMenu(fileName = "MapData", menuName = "ScriptableObjects/Map Data", order = 2)]
public class MapData : ScriptableObject
{
    #region Fields

    [SerializeField] List<GameObject> towerPoints;

    #endregion

    #region GetSets
    public List<GameObject> TowerPoints { get => towerPoints; set => towerPoints = value; }

    #endregion
}
