using System.Collections.Generic;
using UnityEngine;

public class BuilderAI : MonoBehaviour
{ 
    [SerializeField] private List<TowerSettings> towers;
    [SerializeField] private List<GameObject> plots;

    private float waitTimer;

    void Start()
    {
        waitTimer = Random.Range(3, 10);
    }

    void Update()
    {
        if (waitTimer > 0)
        {
            waitTimer -= Time.deltaTime;
            return;
        }
        BuildTower();
    }

    private void BuildTower()
    {
        TowerSettings tower = PickTower();
        if (GameData.enemyGold < tower.cost) return;
        GameObject plot = PickPlot();
        GameObject obj = Instantiate(tower.prefab, plot.transform.position, Quaternion.identity, plot.transform.parent.transform);
        GameData.enemyGold -= tower.cost;
        plots.Remove(plot);
        Destroy(plot);
        waitTimer = Random.Range(3, 10);
    }

    private GameObject PickPlot()
    {
        return plots[Random.Range(0, plots.Count)];
    }

    private TowerSettings PickTower()
    {
        return towers[Random.Range(0, towers.Count)];
    }
}