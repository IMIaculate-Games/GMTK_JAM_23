using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public string[] songtitles = { "AmberForest", "FiveArmies", "airship", "TheSaddestLonelyOlBeatDramatic", "Crypto" };

    public Transform startPoint;
    public Transform[] path;

    private void Awake()
    {
        main = this;
    }

    private void Start()
    {
        AudioManager.Instance.PlayMusic(songtitles[SceneManager.GetActiveScene().buildIndex]);
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
