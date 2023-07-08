using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{

    private float speed = 4;
    private Vector3 direction;
    private GameObject destination;

    private bool hasTarget = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hasTarget)
        {
            // set the direction
            direction = destination.transform.position - transform.position;

            // move towards the direction
            transform.Translate(Vector3.Normalize(direction) * speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, destination.transform.position) < 0.05)
            {
                Destroy(gameObject);
            }
        }
    }

    public void SetTarget(GameObject g)
    {
        destination = g;
        hasTarget = true;
    }
}
