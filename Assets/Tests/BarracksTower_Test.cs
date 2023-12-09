using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class BarracksTower_Test : MonoBehaviour
{
    private int soldiersPerGroup;

    /*protected GroupOfSoldiers_Test soldiers;*/
    // next to can be summed up in the future
    private Vector2 setLocationOfGroup;
    private Vector2 offSet = new Vector2(1.0f,1.0f); //Needs to be changed to dynamically suit the path nearby;
    [SerializeField]
    protected BarracksData_Test barracksData;
    protected float respawnCooldown;
    protected int barracksTier;
    protected float barracksRange;
    protected int spawnedSoldiers;
    [SerializeField]
    protected GameObject soldierPrefab;

    /* private Animator animator;*/

    public void Initialize()
    {
        soldiersPerGroup = barracksData.numberOfSoldiers;
        barracksTier = barracksData.barracksTier;
        barracksRange = barracksData.towerRange;
        respawnCooldown = barracksData.respawnCooldown;
        /*soldiers = new GroupOfSoldiers_Test(soldiersPerGroup, setLocationOfGroup+offSet);*/

    }

    protected void Start()
    {
        Initialize();
        this.setLocationOfGroup = transform.position;
        for(int i = 0; i <= soldiersPerGroup; i++)
        {
            spawnSoldier();
        }
        /*animator = GetComponentInChildren<Animator>();*/
    }

    // Update is called once per frame
    protected  void Update()
    {
         
        if (spawnedSoldiers < soldiersPerGroup)
        {
            float respawnTimer = respawnCooldown;
            respawnTimer -= Time.deltaTime;
            if (respawnTimer < 0)
            {
                respawnTimer = respawnCooldown;
                spawnSoldier();


                    /*ar.GetComponent<Arrow>().SetTarget(closestTarget, Random.Range(damage.min, damage.max));*/

                    /* AudioManager.Instance.PlaySfx("ArrowOut");*/

                    /*Vector3 direction = Vector3.Normalize(closestTarget.transform.position - animator.transform.position);

                    if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
                    {
                        if (direction.x < 0)
                        {
                            animator.Play("ArcherAttackLeft");
                        }
                        else
                        {
                            animator.Play("ArcherAttackRight");
                        }
                    }
                    else
                    {
                        if (direction.y < 0)
                        {
                            animator.Play("ArcherAttackFront");
                        }
                        else
                        {
                            animator.Play("ArcherAttackBack");
                        }
                    }*/
                
            }

        }

    }
    private void spawnSoldier()
    {
        Instantiate(soldierPrefab);
        spawnedSoldiers++;
    }
    public int getSpawnedSoldiers()
    {
        return spawnedSoldiers;
    }
    public void setSpawnedSoldiers(int x)
    {
        spawnedSoldiers = x;
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.GetComponent<Attackable>() != null)
        {
            inRange.Add(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Attackable>() != null)
        {
            inRange.Remove(collision.gameObject);
        }
    }*/

    // returns the closest gameObject in inRange to this tower
    /*private GameObject getClosestTarget()
    {
        GameObject target = inRange[0];
        float minDistace = Vector3.Distance(gameObject.transform.position, target.transform.position);
        foreach (GameObject g in inRange)
        {
            float gDistance = Vector3.Distance(gameObject.transform.position, g.transform.position);
            if (minDistace > gDistance)
            {
                target = g;
                minDistace = gDistance;
            }
        }
        return target;
    }*/
}
