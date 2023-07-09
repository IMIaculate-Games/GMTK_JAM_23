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

    private Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        target = LevelManager.main.path[Index];

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(target.position, transform.position) <= 0.1f)
        {
            Index++;

            if(Index == LevelManager.main.path.Length)
            {
                Destroy(gameObject);
                return;
            } else
            {
                target = LevelManager.main.path[Index];

                
            }

            Vector3 animDirection = Vector3.Normalize(target.position - transform.position);
            if (Mathf.Abs(animDirection.x) > Mathf.Abs(animDirection.y))
            {
                if (animDirection.x < 0)
                {
                    //walk left
                    animator.Play("walk_left");
                }
                else
                {
                    //walk right
                    animator.Play("walk_right");
                }
            }
            else
            {
                if (animDirection.y < 0)
                {
                    //walk down
                    animator.Play("walk_down");
                }
                else
                {
                    //walk up
                    animator.Play("walk_up");
                }
            }
        }

        Vector3 direction = Vector3.Normalize(target.position - transform.position);

        myRigidbody.velocity = moveSpeed * Time.deltaTime * direction;
    }
}
