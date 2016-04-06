using UnityEngine;
using System.Collections;

public class UnlockStudy : MonoBehaviour {
    
    public bool requiredButtonPress;
    public bool waitForPress;
    public int itemCheckValue;
    public Collider2D c1;
    public Collider2D c2;

    public TextBoxManager tBox;
    public ActivateTextAtLine aBox;

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
        if (Input.GetKeyDown(KeyCode.Z) && waitForPress)
        {
            c1.enabled = false;
            c2.enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter" && inv.CheckIfItemIsInInventory(itemCheckValue) && requiredButtonPress)
        {
            aBox.continueText = true;
            waitForPress = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        waitForPress = false;
    }
}
