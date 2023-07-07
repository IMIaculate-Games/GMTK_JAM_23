using System;
using System.Collections.Generic;
using UnityEngine;

public class BuilderAI : MonoBehaviour
{
    #region Serialized Fields

    [SerializeField] private MapData map;
    [SerializeField] private EnemyData resources;
    [SerializeField] private WaveData waves;

    #endregion Serialized Fields

    #region Fields

    private Wave currentWave, nextWave;

    #endregion Fields

    #region Built-Ins / MonoBehaviours

    void Awake()
    {
        
    }

    void Start()
    {
        if (!waves.IsEmpty)
            currentWave = waves.NextWave;

        CheckMobs(currentWave);
        CheckResources();
        BuildTowers();
    }

    

    void Update()
    {

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

    private void BuildTowers()
    {
        throw new NotImplementedException();
    }

    private void CheckResources()
    {
        throw new NotImplementedException();
    }

    private void CheckMobs(Wave wave)
    {
    }

    #endregion Game Mechanics / Methods

    #region Overarching Methods / Helpers



    #endregion Overarching Methods / Helpers
}