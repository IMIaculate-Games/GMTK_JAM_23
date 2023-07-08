using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScript : MonoBehaviour
{
    public GameObject displayPF;

    bool dragging = false;

    Vector2 standardPos;

    GameObject _UIManager;
    UIManagerScript _UIScript;


    void Start()
    {
        standardPos = transform.position;
        _UIManager = GameObject.Find("UIManager");
        _UIScript = GetComponent<UIManagerScript>();
    }

    public void mouseHold()
    {
        dragging = true;
    }

    public void mouseRelease()
    {
        dragging = false;
        GameObject display = Instantiate(displayPF, standardPos, Quaternion.identity);
        display.transform.SetParent(GameObject.Find("UpperButtonContainer").transform);
        display.transform.position = standardPos;

        gameObject.SetActive(false);
    }


    void Update()
    {
        if (dragging)
        {
            transform.position = Input.mousePosition;
        }
    }
}
