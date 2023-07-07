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
    protected float attackSpeed;
    protected Sprite sprite;

    protected CircleCollider2D circleCollider;

    protected List<GameObject> inRange;

    protected float attackTimer;


    // Start is called before the first frame update
    protected virtual void Start()
    {
        type = settings.type;
        damage = settings.damage;
        cost = settings.cost;
        range = settings.range;
        attackSpeed = settings.attackSpeed;

        circleCollider = GetComponent<CircleCollider2D>();
        circleCollider.radius = range;

        inRange = new List<GameObject>();

        attackTimer = attackSpeed;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }
}
