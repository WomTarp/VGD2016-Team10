using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoInside : MonoBehaviour {

    public bool requireButtonPress;
    private bool waitForPress;
    private bool flag;
    public Inventory inv;
    public int itemCheckValue;
    
    void Start () {
        flag = false;
        inv = GameObject.Find("MainCharacter").GetComponentInChildren<Inventory>();
    }
	
	// Update is called once per frame
	void Update () {
        if (flag)
        {
            DestroyObject(GetComponent<ActivateTextAtLine>());
            flag = false;
        }
        if (waitForPress && Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene(3);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter" && requireButtonPress && inv.CheckIfItemIsInInventory(itemCheckValue)) 
        {
            waitForPress = true;
            flag = true;
            return;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "MainCharacter") waitForPress = false;
    }
}
