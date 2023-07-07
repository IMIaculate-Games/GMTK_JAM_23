using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerScript : MonoBehaviour
{
    //Prefabs
    public GameObject generalButton;

    public GameObject enemyImage;

    //Objects
    GameObject startButton;

    GameObject sendButton;

    GameObject canvas;

    GameObject[] adders;


    // Start is called before the first frame update
    void Start()
    {
        startButton = GameObject.Find("/UI Manager/Canvas/New_Wave_Button");
        sendButton = GameObject.Find("/UI Manager/Canvas/Send_Wave_Button");

        canvas = GameObject.Find("/UI Manager/Canvas");
        Debug.Log("Found: " + startButton.name);

        adders = GameObject.FindGameObjectsWithTag("Adder_Button");

        //deactivating menu buttons
        for(int i = 0; i < adders.Length; i++)
        {
            adders[i].SetActive(false);
        }
        sendButton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /*
     * Show new Buttons to create a new wave 
    */
    public void openMenu()
    {
        startButton.SetActive(false);

        sendButton.SetActive(true);

        for(int i = 0; i < adders.Length; i++)
        {
            adders[i].SetActive(true);
        }
    }

    public void adderPressed(GameObject button)
    {
        GameObject addedImage = Instantiate(enemyImage);

        addedImage.transform.SetParent(canvas.transform, true);

        addedImage.transform.position = new Vector3(button.transform.position.x, button.transform.position.y - 50, 0);
    }

    public void sendWave()
    {

    }

    public void goBack()
    {

    }

    private void showMenu(bool shown)
    {
        if(shown)
        {

        }
    }
}
