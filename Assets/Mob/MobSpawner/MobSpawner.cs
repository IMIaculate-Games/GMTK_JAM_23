using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    private float spawnRate = 1; // time in seconds between each spawn
    private float spawnTimer;
    private bool mobsLoaded = false;
    private Queue<string> mobs;

    [SerializeField]
    private GameObject goblin;
    [SerializeField]
    private GameObject wolf;
    [SerializeField]
    private GameObject slime;
    [SerializeField]
    private GameObject flying;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnRate;
        mobs = new Queue<string>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mobsLoaded)
        {
            spawnTimer -= Time.deltaTime;

            if(spawnTimer < 0)
            {
                spawnTimer = spawnRate;

                if(mobs.Count > 0)
                {

                    switch (mobs.Dequeue())
                    {
                        case "goblin":
                            Instantiate(goblin, transform);
                            break;
                        case "wolf":
                            Instantiate(wolf, transform);
                            break;
                        case "slime":
                            Instantiate(slime, transform);
                            break;
                        case "flying":
                            Instantiate(flying, transform);
                            break;
                    }
                }
                else
                {
                    mobsLoaded = false;
                } 
            }
        }
    }

    // this method needs a list of mob gameobjects to spawn
    public void LoadMobs(string[] mobList)
    {
        foreach (string mob in mobList)
        {
            mobs.Enqueue(mob);
        }
        mobsLoaded = true;
    }
}
