using UnityEngine;
using System.Collections;

public class SpecialCheckItem : MonoBehaviour {

    public bool destroyWhenActivated;
    public bool requiredButtonPress;
    public bool waitForPress;
    public bool getItem;
    public int itemCheckValue;
    public int itemGetValue;
    public bool removeItem;
    public int activated = 0;

    public TextBoxManager tBox;
    public ActivateTextAtLine aBox;

    public GameObject g;

    public Inventory inv;
    // Use this for initialization
    void Start()
    {
        tBox = FindObjectOfType<TextBoxManager>();
        inv = GameObject.Find("MainCharacter").GetComponentInChildren<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && waitForPress && activated == 0)
        {
            if (removeItem) { inv.removeItem(itemCheckValue); }
            if (getItem) inv.AddItem(itemGetValue);
            g.SetActive(true);
            if (destroyWhenActivated) Destroy(gameObject.GetComponent<CheckItem>());
            activated = 1;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter" && inv.CheckIfItemIsInInventory(itemCheckValue) && requiredButtonPress)
        {
            aBox.enabled = true;
            aBox.continueText = true;
            waitForPress = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        waitForPress = false;
    }
}
