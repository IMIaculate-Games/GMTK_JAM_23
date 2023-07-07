using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTarget : MonoBehaviour, Attackable
{
    public void Attacked(int damage, bool isMagic, bool isRanged)
    {
        Debug.Log("Got attacked!");
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * 5 * Time.deltaTime);
    }

}
