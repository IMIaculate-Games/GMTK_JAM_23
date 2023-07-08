using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MobData", menuName = "ScriptableObjects/Mob Data", order = 2)]
/// <summary>
/// TODO: Provide a summary of your script here.
/// To create an auto-generated summary template
/// type 3 /// slash characters after you have
/// written your class or method signature.
/// </summary>
public class MobData : ScriptableObject
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

    [SerializeField]
    protected float effectiveRange, movementSpeed, attackSpeed;

    [SerializeField]
    protected int unitCost, damagePoints, healthPoints, goldGivenOnKill;

    [SerializeField]
    protected bool isFlying;

    

    //public MobType type;


    #endregion Serialized Fields

    #region GetSets / Properties

 
    public float MovementSpeed { get => movementSpeed; }
    public float AttackSpeed { get => attackSpeed; }
    public float EffectiveRange { get => effectiveRange;}
    public int UnitCost { get => unitCost; }
    public int DamagePoints { get => damagePoints; }
    public int HealthPoints { get => healthPoints;}
    public int GoldGivenOnKill { get => goldGivenOnKill;}
    public bool IsFlying { get => isFlying;}

    #endregion GetSets / Properties

    #region Game Mechanics / Methods




    #endregion Game Mechanics / Methods

    #region Overarching Methods / Helpers

    // TODO: Put your helper methods here.

    #endregion Overarching Methods / Helpers
}