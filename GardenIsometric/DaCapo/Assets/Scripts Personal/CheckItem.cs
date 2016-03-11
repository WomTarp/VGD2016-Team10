using UnityEngine;
using System.Collections;

public class CheckItem : MonoBehaviour {

    public bool destroyWhenActivated;
    public bool requiredButtonPress;
    private bool waitForPress;
    public bool getItem;
    public int itemCheckValue;
    public int itemGetValue;

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
        if (Input.GetKeyDown(KeyCode.Z) && waitForPress && getItem)
        {
            inv.AddItem(itemGetValue);
            if (destroyWhenActivated) Destroy(gameObject.GetComponent<CheckItem>());
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter" && inv.CheckIfItemIsInInventory(itemCheckValue) && requiredButtonPress)
        {
            aBox.continueText = true;
            waitForPress = true;
            return;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        waitForPress = false;
        return;
    }
}
