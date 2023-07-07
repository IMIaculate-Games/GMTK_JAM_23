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

    GameObject backButton;

    GameObject canvas;

    GameObject[] adders;


    Dictionary<GameObject, int> hash;

    List<GameObject> images;


    // Start is called before the first frame update
    void Start()
    {
        startButton = GameObject.Find("/UI Manager/Canvas/LowerButtonContainer/New_Wave_Button");
        sendButton = GameObject.Find("/UI Manager/Canvas/LowerButtonContainer/Send_Wave_Button");
        backButton = GameObject.Find("/UI Manager/Canvas/LowerButtonContainer/Back_Button");

        canvas = GameObject.Find("/UI Manager/Canvas");
        Debug.Log("Found: " + startButton.name);

        adders = GameObject.FindGameObjectsWithTag("Adder_Button");

        //deactivating menu buttons
        for(int i = 0; i < adders.Length; i++)
        {
            adders[i].SetActive(false);
        }
        sendButton.SetActive(false);
        backButton.SetActive(false);


        hash = new Dictionary<GameObject,int>();
        images = new List<GameObject>();
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

        showMenu(true);
    }

    public void adderPressed(GameObject button)
    {
        if(!hash.ContainsKey(button)) 
        {
            hash.Add(button, 1);
        }

        int imgNumber = hash[button];

        hash.Remove(button);
        hash.Add(button, imgNumber+1);

        GameObject addedImage = Instantiate(enemyImage);

        images.Add(addedImage);

        addedImage.transform.SetParent(canvas.transform, true);

        addedImage.transform.position = new Vector3(button.transform.position.x, button.transform.position.y - (50 * imgNumber), 0);
    }

    public void sendWave()
    {
        showMenu(false);
        startButton.SetActive(true);
    }

    public void goBack()
    {
        showMenu(false);
        startButton.SetActive(true);
    }

    private void showMenu(bool shown)
    {
        if(shown)
        {
            sendButton.SetActive(true);
            backButton.SetActive(true);

            for (int i = 0; i < adders.Length; i++)
            {
                adders[i].SetActive(true);
            }
        }
        else
        {
            sendButton.SetActive(false);
            backButton.SetActive(false);

            for (int i = 0; i < adders.Length; i++)
            {
                adders[i].SetActive(false);
            }

            foreach(GameObject g in images){
                Destroy(g);
            }
        }
    }
}
