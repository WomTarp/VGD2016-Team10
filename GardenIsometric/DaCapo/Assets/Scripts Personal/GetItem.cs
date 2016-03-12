using UnityEngine;
using System.Collections;

public class GetItem : MonoBehaviour {

    public bool destroyWhenActivated;
    public bool requiredButtonPress;
    private bool waitForPress;
    public int itemGetValue;
    public bool pickUpChangesScene;
    public bool doChangeScene;
    public int sceneToChange;

    public Inventory inv;
    // Use this for initialization
    void Start () {
        inv = GameObject.Find("MainCharacter").GetComponentInChildren<Inventory>();
    }
	
	// Update is called once per frame
	void Update () {
        if (waitForPress && Input.GetKeyDown(KeyCode.Z))
        {
            inv.AddItem(itemGetValue);
            if (pickUpChangesScene) doChangeScene = true; 
            if (destroyWhenActivated) gameObject.SetActive(false);
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
