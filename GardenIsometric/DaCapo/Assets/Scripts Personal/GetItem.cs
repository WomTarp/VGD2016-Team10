using UnityEngine;
using System.Collections;

public class GetItem : MonoBehaviour {

    public bool destroyWhenActivated;
    public bool requiredButtonPress;
    private bool waitForPress;

    public PlayerInventory inv;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (waitForPress && Input.GetKeyDown(KeyCode.X))
        {
            inv.stick = true;
            if (destroyWhenActivated) Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Girl" && requiredButtonPress)
        {
                waitForPress = true;
                return;
        }
    }
}
