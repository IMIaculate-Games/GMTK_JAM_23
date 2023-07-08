using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class SlotScript : MonoBehaviour
{
    Sprite sprite;
    Image image;

    UIManagerScript _UIScript;

    bool onSlot = false;
    

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();

        _UIScript = GameObject.FindWithTag("UI_Manager").GetComponent<UIManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) && onSlot)
        {
            sprite = _UIScript.getDraggedMob().GetComponent<Image>().sprite;
            image.sprite = sprite;
        }
    }

    public void enter()
    {
        onSlot = true;
    }

    public void exit()
    {
        onSlot = false;
    }


}
