using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    //Prefabs
    public GameObject generalButton;

    public GameObject deleteButton;

    public Sprite goblinSprite;

    public Sprite wolfSprite;

    public Sprite emptySprite;

    //Objects
    GameObject startButton;

    GameObject sendButton;

    GameObject backButton;

    GameObject canvas;

    Dictionary<GameObject, int> hash;

    GameObject[] adders;

    List<GameObject> images;

    GameObject[] slots;

    int currentSlotIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        hash = new Dictionary<GameObject, int>();
        images = new List<GameObject>();

        startButton = GameObject.Find("/UI Manager/Canvas/LowerButtonContainer/New_Wave_Button");
        sendButton = GameObject.Find("/UI Manager/Canvas/LowerButtonContainer/Send_Wave_Button");
        backButton = GameObject.Find("/UI Manager/Canvas/LowerButtonContainer/Back_Button");

        canvas = GameObject.Find("/UI Manager/Canvas");

        adders = GameObject.FindGameObjectsWithTag("Adder_Button");

        slots = GameObject.FindGameObjectsWithTag("UI_SLot");


        //deactivating menu buttons
        showMenu(false);
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void addMobToList(string mob)
    {
        switch (mob)
        {
            case "goblin":
                if (currentSlotIndex < slots.Length)
                { 
                    slots[currentSlotIndex].gameObject.GetComponent<Image>().sprite = goblinSprite;
                    currentSlotIndex++;
                }
                break;
            case "wolf":

                break;
            default:

                break;
        }
    }

    public void delete()
    {
        if(currentSlotIndex >= 0)
        {
            slots[currentSlotIndex].gameObject.GetComponent<Image>().sprite = emptySprite;
            if(currentSlotIndex != 0)
            {
                currentSlotIndex--;
            }
        }

    }


    public void openMenu()
    {
        startButton.SetActive(false);

        showMenu(true);
    }


    public void sendWave()
    {
        showMenu(false);
        hash.Clear();
    }

    public void goBack()
    {
        showMenu(false);
        hash.Clear();
    }


    private void showMenu(bool shown)
    {
        if(shown)
        {
            startButton.SetActive(false);

            deleteButton.SetActive(true);
            sendButton.SetActive(true);
            backButton.SetActive(true);

            arraySetActive(adders, true);

            arraySetActive(slots, true);

        }
        else
        {
            startButton.SetActive(true);

            deleteButton.SetActive(false);
            sendButton.SetActive(false);
            backButton.SetActive(false);

            arraySetActive(adders, false);

            arraySetActive(slots, false);


        }
    }

    private void arraySetActive(GameObject[] objects, bool active)
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(active);
        }
    }
}
