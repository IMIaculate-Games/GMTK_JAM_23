using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour
{
    public static LevelManagerScript main;

    public Transform startPoint;
    public Transform[] path;



    private void Awake()
    {
        main = this;
    }
}
