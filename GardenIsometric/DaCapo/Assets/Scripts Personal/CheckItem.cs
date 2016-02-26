using UnityEngine;
using System.Collections;

public class CheckItem : MonoBehaviour {

    public bool destroyWhenActivated;
    public bool requiredButtonPress;
    private bool waitForPress;

    public TextBoxManager tBox;
    public ActivateTextAtLine aBox;

    public PlayerInventory inv;
    // Use this for initialization
    void Start()
    {
        tBox = FindObjectOfType<TextBoxManager>();
    }

    // Update is called once per frame
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.X) && waitForPress)
        {
            aBox.continueText = true;
            inv.musicSheet1 = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Girl" && inv.stick && requiredButtonPress)
        {
            waitForPress = true;
            return;
        }
    }
}
