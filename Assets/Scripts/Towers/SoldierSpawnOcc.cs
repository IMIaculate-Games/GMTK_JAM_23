using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierSpawnOcc : MonoBehaviour
{
    private GameObject spawnLocation;

    public void setSpawnLocation(GameObject sl)
    {
        spawnLocation = sl;
    }

    private void OnDestroy()
    {
        spawnLocation.gameObject.GetComponent<SpawnLocation>().isOccupied = false;
    }
}
