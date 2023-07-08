using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class SlotScript : MonoBehaviour
{
    public Sprite sprite;
    Image image;


    GameObject _UIManager;
    UIManagerScript _UIScript;
    

    // Start is called before the first frame update
    void Start()
    {
        _UIManager = GameObject.Find("UIManager");
        _UIScript = GetComponent<UIManagerScript>();

        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void endDrag()
    {
        Debug.Log("Ended drag");
        image.sprite = sprite;
    }

}
