using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CannonTower : Tower
{
    [SerializeField]
    private GameObject cannonball;

    private List<GameObject> aoeTargets;
    private float aoe = 1;

    protected override void Start()
    {
        base.Start();
        aoeTargets = new List<GameObject>();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        attackTimer -= Time.deltaTime;
        if (attackTimer < 0)
        {
            attackTimer = 1 / attackSpeed;
            if (inRange.Count > 0)
            {
                // still need to change and define attack aoe ...

                // get closest target
                GameObject closestTarget = getClosestTarget();

                GameObject proj = Instantiate(cannonball, transform);

                proj.GetComponent<CannonBall>().SetTarget(closestTarget);


                // get all colliders around the closestTarget in an aoe
                Collider2D[] targets = Physics2D.OverlapCircleAll(closestTarget.transform.position, aoe);

                // check if the targets in the array are attackables
                foreach (Collider2D target in targets)
                {
                    if(target.gameObject.GetComponent<Attackable>() != null)
                    {
                        // if attackable, add them to aoe targets
                        aoeTargets.Add(target.gameObject);
                    }
                }

                // attack all the attackables in aoe radius
                foreach(GameObject target in aoeTargets)
                {
                    target.GetComponent<Attackable>().Attacked(damage, false, true);
                }

                aoeTargets.Clear();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered");
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
    }

    // returns the closest gameObject in inRange to this tower
    private GameObject getClosestTarget()
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
    }
}
