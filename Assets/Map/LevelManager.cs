using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform startPoint;
    public Transform[] path;

    private void Awake()
    {
        main = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Mob mob = collision.GetComponent<Mob>();
        if (mob != null)
        {
            GameData.enemyLives -= 1;
            Debug.Log(GameData.enemyLives);
        }
    }
}
