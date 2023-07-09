
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// TODO: Provide a summary of your script here.
/// To create an auto-generated summary template
/// type 3 /// slash characters after you have
/// written your class or method signature.
/// </summary>
public class Speedster : Mob
{

    #region Fields

    public Rigidbody2D rg;
    private Animator animator;
    
    #endregion Fields

    #region Built-Ins / MonoBehaviours

    // TODO: Put Unity built-in event methods here.
    // Such as Awake, Start, Update.
    // But also OnEnable, OnDestroy, OnTrigger and such.

    void Awake()
    {
        base.Initialize();
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    #endregion Built-Ins / MonoBehaviours

    #region GetSets / Properties

    #endregion GetSets / Properties

    #region Game Mechanics / Methods

    public override void Attacked(int damage, bool isMagic, bool isRanged)
    {

        if (isMagic)
        {
            TakeDamage(damage);
            return;
        }
        if (isRanged && !isMagic)
        {
            int evasionNumber = Random.Range(1, 101);
            int critChance = Random.Range(1, 1000);
            if (evasionNumber <= evasionChance)
            {
                TakeDamage(0);
                return;
            }
            if (critChance <= 10)
            {
                Debug.Log("CRIT!");
                TakeDamage(damage * 2);
                return;
            }
            TakeDamage(damage - this.resistance);

        }
        TakeDamage(damage - resistance);


        //throw new NotImplementedException();
    }
    public override void TakeDamage(int damage)
    {
        if (healthPoints == 0)
        {
            Debug.Log("Miss!");
        }
        healthPoints -= damage;
        if (healthPoints <= 0)
        {
            //UnitDeath();
            animator.Play("death");
        }
    }

    public override void UnitDeath()
    {
        //Optional Death animation lol
        UpdateGameData();
        Destroy(gameObject);
    }
    
    #endregion Game Mechanics / Methods

    #region Overarching Methods / Helpers

    // TODO: Put your helper methods here.

    #endregion Overarching Methods / Helpers
}