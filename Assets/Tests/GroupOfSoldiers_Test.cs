using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GroupOfSoldiers_Test : MonoBehaviour
{
    protected int maxNumberOfSoldiers;
    protected Vector2 setLocation;
    protected List<Soldier_Test> soldiersInGroup = new List<Soldier_Test>();

    public GroupOfSoldiers_Test(int soldierNumber, Vector2 location)
    {
        this.maxNumberOfSoldiers = soldierNumber;
        this.setLocation = location;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addSoldierToGroup(Soldier_Test soldier)
    {
        soldiersInGroup.Add(soldier);
        spawnSoldier(soldier);
    }
    private void spawnSoldier(Soldier_Test soldier)
    {
        Instantiate(soldier);
    }
    private void moveSoldierToSetLocation()
    {

    }


    public int currentSoldierCount()
    {
        return soldiersInGroup.Count;
    }
    public void set_maxNumberOfSoliders(int number)
    {
        this.maxNumberOfSoldiers = number;
    }
    public int get_maxNumberOfSoldiers()
    {
        return this.maxNumberOfSoldiers;
    }
    public void set_setLocation(Vector2 location)
    {
        this.setLocation = location;
    }
    public Vector2 get_setLocation()
    {
        return this.setLocation;
    }
}
