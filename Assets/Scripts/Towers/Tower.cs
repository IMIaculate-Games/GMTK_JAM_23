using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public abstract class Tower : MonoBehaviour
{
    [SerializeField]
    private TowerSettings settings;

    private string type;
    private int damage;
    private int cost;
    private int range;
    private int speed;
    private Sprite sprite;

    private CircleCollider2D circleCollider;

    private List<Attackable> inRange;


    // Start is called before the first frame update
    protected virtual void Start()
    {
        type = settings.type;
        damage = settings.damage;
        cost = settings.cost;
        range = settings.range;
        speed = settings.speed;

        circleCollider = GetComponent<CircleCollider2D>();
        circleCollider.radius = range;

        inRange = new List<Attackable>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Attackable>() != null)
        {
            inRange.Add(collision.gameObject.GetComponent<Attackable>());
        }
    }


}
