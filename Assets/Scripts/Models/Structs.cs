using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Made by <see href="https://github.com/n-c0de-r" langword="n-c0de-r" />
/// </summary>

/// <summary>
/// Contains the game's individual action descriptions for each key.
/// </summary>
[Serializable]
public struct ActionName
{
    [SerializeField] private string one, two, three, four;
    public string One { get => one; }
    public string Two { get => two; }
    public string Three { get => three; }
    public string Four { get => four; }
    public string[] All { get => new[] { one, two, three, four }; }
}

/// <summary>
/// Represents a collective structure holding action references a game can use.
/// Makes button remapping kinda indepedant of a global manager.
/// Might be obsolete by a better gobal built-in button map management?
/// </summary>
[Serializable]
public struct KeyMap
{
    [SerializeField] private Key one, two, three, four;

    public Key One { get => one; }
    public Key Two { get => two; }
    public Key Three { get => three; }
    public Key Four { get => four; }
    public Key[] All { get => new[] { one, two, three, four }; }
}

[Serializable]
public struct Wave
{
    //[SerializeField] private List<Mob> mobs;
    [SerializeField] private List<GameObject> mobs;

    //public List<Mob> Mobs { get => mobs; set => mobs = value; }
    public List<GameObject> Mobs { get => mobs; set => mobs = value; }
    public int EnemyNumber { get => mobs.Count; }
}