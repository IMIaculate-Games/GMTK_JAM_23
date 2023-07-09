using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    private float spawnRate = 1; // time in seconds between each spawn
    private float spawnTimer;
    private bool mobsLoaded = false;
    private Queue<GameObject> mobs;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnRate;
        mobs = new Queue<GameObject>();
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
                    GameObject mob = mobs.Dequeue();
                    Instantiate(mob, transform);
                }
                else
                {
                    mobsLoaded = false;
                } 
            }
        }
    }

    // this method needs a list of mob gameobjects to spawn
    public void LoadMobs(List<GameObject> mobList)
    {
        foreach (GameObject mob in mobList)
        {
            mobs.Enqueue(mob);
        }
        mobsLoaded = true;
    }
}
