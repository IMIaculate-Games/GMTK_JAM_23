using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArcherTower : Tower
{
    // Start is called before the first frame update

    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if(inRange.Count > 0 )
        {

        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Attackable>() != null)
        {
            inRange.Add(collision.gameObject);
        }
    }

    // returns the closest gameObject in inRange to this tower
    private GameObject getClosestTarget()
    {
        GameObject target = inRange[0];
        float minDistace = Vector3.Distance(gameObject.transform.position, target.transform.position);
        foreach (GameObject g in inRange)
        {
            if(minDistace > Vector3.Distance(gameObject.transform.position, g.transform.position))
            {
                target = g;
                minDistace = Vector3.Distance(gameObject.transform.position, g.transform.position);
            }
        }
        return target;
    }
}
