using UnityEngine;
using System.Collections;

public class QuadrupleCheckItem : MonoBehaviour {

    public bool destroyWhenActivated;
    public bool requiredButtonPress;
    public bool waitForPress;
    public int[] itemCheckValue = new int[4];
    public int activated = 0;

    public TextBoxManager tBox;
    public ActivateTextAtLine aBox;
    public Inventory inv;
    public GameObject key;
    void Start()
    {
        tBox = FindObjectOfType<TextBoxManager>();
        inv = GameObject.Find("MainCharacter").GetComponentInChildren<Inventory>();
    }
    
    void Update () {
        if (Input.GetKeyDown(KeyCode.Z) && waitForPress && activated == 0)
        {
            key.SetActive(true);
            key.GetComponent<KeyPad>().itemsCollected = true;
            key.GetComponent<KeyPad>().onTrigger = true;
            this.enabled = false;
            activated = 1;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter" && checkInventory() && requiredButtonPress)
        {
            aBox.continueText = true;
            waitForPress = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        waitForPress = false;
    }

    bool checkInventory()
    {
        for (int i = 0; i < itemCheckValue.Length; i++)
        {
            if (!inv.CheckIfItemIsInInventory(itemCheckValue[i])) return false;
        }
        return true;
    }
}
