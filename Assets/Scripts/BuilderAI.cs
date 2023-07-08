using System.Collections.Generic;
using UnityEngine;

public class BuilderAI : MonoBehaviour
{
    #region Serialized Fields

    [SerializeField] private List<TowerSettings> towers;
    [SerializeField] private List<GameObject> plots;
    //[SerializeField] private MapData map;
    //[SerializeField] private EnemyData resources;
    //[SerializeField] private WaveData waves;

    #endregion Serialized Fields

    #region Fields

    private float waitTimer;

    #endregion Fields

    #region Built-Ins / MonoBehaviours

    void Awake()
    {
        
    }

    void Start()
    {
        BuildTower();
    }

    

    void Update()
    {
        while (waitTimer > 0)
        {
            waitTimer -= Time.deltaTime;
        }
        BuildTower();
    }

    void OnEnable()
    {
        
    }

    void OnDisable()
    {
        
    }

    #endregion Built-Ins / MonoBehaviours

    #region GetSets / Properties



    #endregion GetSets / Properties

    #region Game Mechanics / Methods

    private void BuildTower()
    {
        TowerSettings tower = PickTower();
        if (EnemyData.Gold < tower.cost) return;
        GameObject plot = PickPlot();
        //Instantiate(tower.prefab, plot.transform.position, Quaternion.identity, plot.transform);
        Destroy(plot);
        waitTimer = Random.Range(2, 5);
    }

    private GameObject PickPlot()
    {
        return plots[Random.Range(0, plots.Count)];
    }

    private TowerSettings PickTower()
    {
        return towers[Random.Range(0, towers.Count)];
    }

    private bool CheckResources()
    {
        return false;
    }

    private void CheckMobs(/*Wave wave*/)
    {
    }

    #endregion Game Mechanics / Methods

    #region Overarching Methods / Helpers



    #endregion Overarching Methods / Helpers
}