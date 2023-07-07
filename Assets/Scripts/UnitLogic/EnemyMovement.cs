using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private Rigidbody2D myRigidbody;


    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f; //The Speed defined by the Enemy speed property

    private Transform target;

    private int Index = 0;


    // Start is called before the first frame update
    void Start()
    {
        target = LevelManagerScript.main.path[Index];
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(target.position, transform.position) <= 0.1f)
        {
            Index++;

            if(Index == LevelManagerScript.main.path.Length)
            {
                Destroy(gameObject);
                return;
            } else
            {
                target = LevelManagerScript.main.path[Index];
            }
        }
    }

    private void FixedUpdate()
    {
        Vector2 direction = (target.position - transform.position).normalized;

        myRigidbody.velocity = direction * moveSpeed;
    }
}
