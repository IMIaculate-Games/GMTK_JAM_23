using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MageTower : Tower
{

    [SerializeField]
    private GameObject fireball;

    protected override void Start()
    {
        base.Start();
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
                GameObject closestTarget = getClosestTarget();
                GameObject proj = Instantiate(fireball, transform);
                proj.GetComponent<FireBall>().SetTarget(closestTarget);
                closestTarget.GetComponent<Attackable>().Attacked(damage, true, true);
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
