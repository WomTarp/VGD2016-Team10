using UnityEngine;
using System.Collections;

public class CallInventory : MonoBehaviour {

    private PlayerMovement player;
    public GameObject inventoryPanel;
    private bool inventoryActive;

	void Start () {
        player = GetComponent<PlayerMovement>();
        inventoryPanel = GameObject.Find("InventoryPanel");
    }
	
	// Update is called once per frame
	void Update () {
	    if (player.canInventory && Input.GetKeyDown(KeyCode.C) && !inventoryActive)
        {
            player.canMove = false;
            inventoryActive = true;
            inventoryPanel.SetActive(true);
            player.canExamine = false;
            player.anim.SetBool("WalkRight", false);
            player.anim.SetBool("WalkUp", false);
            player.anim.SetBool("WalkDown", false);
            player.anim.SetBool("WalkLeft", false);
        }
        else if (player.canInventory && inventoryActive && Input.GetKeyDown(KeyCode.X))
        {
            player.canMove = true;
            inventoryActive = false;
            player.canExamine = true;
            inventoryPanel.SetActive(false);
        }
	}
}