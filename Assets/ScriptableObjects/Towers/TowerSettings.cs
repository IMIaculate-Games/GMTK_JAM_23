using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTower", menuName = "ScriptableObjects/Tower")]
public class TowerSettings : ScriptableObject
{
    public string type;
    public int damage;
    public int cost;
    public int range;
    public int speed;
    public Sprite sprite;
}
