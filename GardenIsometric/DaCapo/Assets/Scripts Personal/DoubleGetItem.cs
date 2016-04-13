using UnityEngine;
using System.Collections;

public class DoubleGetItem : MonoBehaviour
{

    public bool destroyWhenActivated;
    public bool requiredButtonPress;
    private bool waitForPress;
    public int itemGetValue1;
    public int itemGetValue2;

    public Inventory inv;
    // Use this for initialization
    void Start()
    {
        inv = GameObject.Find("MainCharacter").GetComponentInChildren<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitForPress && Input.GetKeyDown(KeyCode.Z))
        {
            inv.AddItem(itemGetValue1);
            inv.AddItem(itemGetValue2);
            if (destroyWhenActivated)
            {
                GetComponent<DoubleGetItem>().enabled = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter" && requiredButtonPress)
        {
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
