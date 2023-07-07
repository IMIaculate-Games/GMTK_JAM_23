using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public abstract class Tower : MonoBehaviour
{
    [SerializeField]
    protected TowerSettings settings;

    protected string type;
    protected int damage;
    protected int cost;
    protected int range;
    protected int speed;
    protected Sprite sprite;

    protected CircleCollider2D circleCollider;

    protected List<GameObject> inRange;


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

        inRange = new List<GameObject>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

}
