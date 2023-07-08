using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrackTower : Tower
{
    [SerializeField]
    private GameObject soldier;

    protected override void Start()
    {
        base.Start(); 
        getNearbyPath();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base .Update();
        attackTimer -= Time.deltaTime;
        if (attackTimer < 0)
        {
            attackTimer = 1 / attackSpeed;
            if (inRange.Count > 0)
            {
                GameObject closestTarget = getClosestTarget();
                // for now spawn soldier at closest tile, eventually let him move there
                GameObject sol = Instantiate(soldier, closestTarget.transform);
            }
        }

    }

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

    // get all path tiles nearby
    private void getNearbyPath()
    {
        Collider2D[] collisions = Physics2D.OverlapCircleAll(transform.position, range);

        // check if collisions are path
        foreach (Collider2D coll in collisions)
        {
            // check if the collison object is a spawn location and add it to inRange
        }
    }
}
