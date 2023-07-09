using UnityEngine;

public class Fodder : Mob
{
    #region Fields

    public Rigidbody2D rg;
    private Coroutine fightingCoroutine;
    private float originalSpeed;

    private Animator animator;

    #endregion Fields

    #region Built-Ins / MonoBehaviours

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

    #region Game Mechanics / Methods

    public override void Attacked(int damage, bool isMagic, bool isRanged)
    {

        if (isMagic)
        {
            TakeDamage(damage);
            return;
        }
        if(isRanged && !isMagic)
        {
            int evasionNumber = Random.Range(1, 101);
            int critChance = Random.Range(1, 1000);
            if(evasionNumber <= evasionChance)
            {
                TakeDamage(0);
                return;
            }
            if(critChance <= 10)
            {
                Debug.Log("CRIT!");
                TakeDamage(damage * 2);
                return;
            }            
        }
        TakeDamage(damage - resistance);
        

        //throw new NotImplementedException();
    }
    public override void TakeDamage(int damage)
    {
        if(damage == 0)
        {
            Debug.Log("Missed the" + name +  "!");
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
        DropMoney();
        Destroy(gameObject);
    }

    //public override void OnUnitCollision(Collider2D collision)
    


   /* public void OnTriggerEnter2D(Collider2D collision)
    {
        Soldier opponent = collision.gameObject.GetComponent<Soldier>();
        if (opponent!=null)
        {
            isFighting = true;
            originalSpeed = movementSpeed;
            movementSpeed = 0.0f;
            Attackable target = collision.gameObject.GetComponent<Attackable>();
            if (target != null)          
                fightingCoroutine = StartCoroutine(Attack(target));   
        }
    }*/
   /* public override void InitiateCombat(Soldier opponent)
    {
        //Debug.Log("FIGHT!");
        if(opponent != null)
        { 
            originalSpeed = movementSpeed;
            movementSpeed = 0.0f;
            fightingCoroutine = StartCoroutine(Attack(opponent));
        }
        
    }*/

   /* private IEnumerator Attack(Attackable target)
    {
        

        yield return new WaitForSeconds(1.0f / (attackSpeed / 10.0f));

        if (target == null)
            StopAllCoroutines();

        if (target != null)
        {
            int damage = Random.Range(attackStrength.min, attackStrength.max);
            target.Attacked(damage, isMagic, isRanged);
            StartCoroutine(Attack(target));
        }
        else
        {
            StopAllCoroutines();
            opponentSoldier = null;
            isFighting = false;
            movementSpeed = originalSpeed;
            
        }

    }*/



    /*public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("FIGHTING!");
    }*/
    /*public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("FIGHT OVER!");
        StopCoroutine(fightingCoroutine);
        isFighting = false;
        movementSpeed = originalSpeed;
    }*/
    
    #endregion Game Mechanics / Methods
}