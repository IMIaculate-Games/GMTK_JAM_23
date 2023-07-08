using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// TODO: Provide a summary of your script here.
/// To create an auto-generated summary template
/// type 3 /// slash characters after you have
/// written your class or method signature.
/// </summary>
public abstract class Mob : MonoBehaviour, Attackable
{

    /**
        * TODO: General Structure Ideas:
        * 
        * Try to keep an order of fields from most complex to primitive.
        * GameObject go;
        * struct point;
        * float num;
        * bool truthy;
        * 
        * Constants before variables maybe too.
        * const int TIME_PLANNED_FOR_THIS
        * int timeSpentOnThis
        * 
        * Also from most public to private. Valid for methods too.
        * public
        * internal
        * protected
        * private
        * 
        *  Then only probably by alphabet. If at all
        */

    #region Serialized Fields

    //private float movementSpeed, effectiveRange, attackSpeed;
    //private int unitCost, damagePoints, healthPoints,goldGivenOnKill;
    //public MobType type;

    [SerializeField]
    protected MobData mobData;

    [SerializeField]
    protected float effectiveRange, movementSpeed, attackSpeed;

    [SerializeField]
    protected int unitCost, healthPoints, goldGivenOnKill, resistance, evasionChance;

    [SerializeField]
    protected bool isFlying, isMagic, isRanged;

    protected StatRange attackStrength;

    #endregion Serialized Fields

    #region Fields


    #endregion Fields

    #region Built-Ins / MonoBehaviours

    // TODO: Put Unity built-in event methods here.
    // Such as Awake, Start, Update.
    // But also OnEnable, OnDestroy, OnTrigger and such.

    void Awake()
    {
        // base.SetUp();
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject mobGameObject = GetComponent<GameObject>();
        
    }

    // Update is called once per frame
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

    // TODO: Put Auto-Properties to your fields here.
    //
    // These are used for private fields as getters and setters.
    // Since they are very specific, they are down here.
    // The structure is (amost) always the same. Copy-Paste.

    /**
    public returnType FieldNameWithCapitalStart
    {
        get => fieldName;
        set => fieldName = value;
    }
    */

    #endregion GetSets / Properties

    #region Game Mechanics / Methods

    // TODO: Put your game specific mechanics here.
    // If they can be grouped by functionality, do so.

    /// <summary>
    /// TODO: Provide a summary for the method
    /// </summary>
    /// <param name="param">List the parameters.</param>
    /// <returns>Specify what it returns, if it does so.</returns>

    public void Initialize()
    {
        effectiveRange = mobData.EffectiveRange;
        movementSpeed = Random.Range(mobData.MovementSpeed.min, mobData.MovementSpeed.max);
        attackSpeed = Random.Range(mobData.AttackSpeed.min, mobData.AttackSpeed.max); //Divide by hundred for more reasonable number
        healthPoints = Random.Range(mobData.HealthPoints.min, mobData.HealthPoints.max);
        unitCost = mobData.UnitCost;
        goldGivenOnKill = mobData.GoldGivenOnKill;
        isFlying = mobData.IsFlying;
        attackStrength = mobData.AttackStrength;
        resistance = mobData.Resistance;
        evasionChance = mobData.EvasionChance;
    }

    public abstract void Attacked(int damage, bool isMagic, bool isRanged);

    public abstract void TakeDamage(int damage);

    public abstract void UnitDeath();

    public void Attack(Soldier target)
    {
        Attackable enemyUnit = target.gameObject.GetComponent<Attackable>();
        enemyUnit.Attacked(Random.Range(attackStrength.min, attackStrength.max), isMagic, isRanged);

    }
    public abstract void OnUnitCollision(Collider2D collision);

    public abstract void initiateCombat(GameObject soldier);

    #endregion Game Mechanics / Methods

    #region Overarching Methods / Helpers

    // TODO: Put your helper methods here.

    #endregion Overarching Methods / Helpers
}