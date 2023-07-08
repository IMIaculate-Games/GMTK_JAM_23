using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerScript : MonoBehaviour
{
    //Prefabs
    public GameObject generalButton;

    public GameObject enemyImage;

    public GameObject slot;

    //Objects
    GameObject startButton;

    GameObject sendButton;

    GameObject backButton;

    GameObject canvas;

    GameObject[] adders;

    GameObject[] mobDisplays;

    GameObject draggedObject;

    GameObject currentlyDraggedMob;

    int slotIndex = 0;

    int numberOfSlots = 10; //adjustable

    Dictionary<GameObject, int> hash;

    List<GameObject> images;

    GameObject[] slots;


    // Start is called before the first frame update
    void Start()
    {
        hash = new Dictionary<GameObject, int>();
        images = new List<GameObject>();

        startButton = GameObject.Find("/UI Manager/Canvas/LowerButtonContainer/New_Wave_Button");
        sendButton = GameObject.Find("/UI Manager/Canvas/LowerButtonContainer/Send_Wave_Button");
        backButton = GameObject.Find("/UI Manager/Canvas/LowerButtonContainer/Back_Button");

        canvas = GameObject.Find("/UI Manager/Canvas");
        Debug.Log("Found: " + startButton.name);

        adders = GameObject.FindGameObjectsWithTag("Adder_Button");

        mobDisplays = GameObject.FindGameObjectsWithTag("UI_mobDisplay");

        //set slots based off of "numberOfSlots"
        slots = new GameObject[numberOfSlots];
        for(int i = 0; i < numberOfSlots; i++)
        {
            GameObject slot = Instantiate(this.slot);
            slot.transform.SetParent(GameObject.Find("SlotContainer").transform);
            slots[i] = slot;
        }


        //deactivating menu buttons
        showMenu(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void openMenu()
    {
        startButton.SetActive(false);

        showMenu(true);
    }

    public void setDraggedMob(GameObject mob)
    {
        currentlyDraggedMob = mob;
    }

    public GameObject getDraggedMob()
    {
        return currentlyDraggedMob;
    }


    /*
     * method is not used!
     * @param button: GameObject with sprite representing a mob
     */
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
        hash.Clear();
    }

    public void goBack()
    {
        showMenu(false);
        startButton.SetActive(true);
        hash.Clear();
    }


    private void showMenu(bool shown)
    {
        if(shown)
        {
            sendButton.SetActive(true);
            backButton.SetActive(true);

            arraySetActive(adders, true);

            arraySetActive(slots, true);

            arraySetActive(mobDisplays, true);
        }
        else
        {
            sendButton.SetActive(false);
            backButton.SetActive(false);

            arraySetActive(adders, false);

            arraySetActive(slots, false);

            mobDisplays = GameObject.FindGameObjectsWithTag("UI_mobDisplay");
            arraySetActive(mobDisplays, false);

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
