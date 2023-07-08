using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragScript : MonoBehaviour
{
    public GameObject displayPF;

    bool dragging = false;

    Vector2 standardPos;

    public UIManagerScript _UIScript;


    void Start()
    {
        standardPos = transform.position;
    }

    public void mouseHold()
    {
        dragging = true;
        _UIScript.setDraggedMob(gameObject);
    }

    public void mouseRelease()
    {
        _UIScript.setDraggedMob(null);
        Debug.Log("Released!");
        dragging = false;
        GameObject display = Instantiate(displayPF, standardPos, Quaternion.identity);
        display.transform.SetParent(GameObject.Find("Canvas").transform);
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
