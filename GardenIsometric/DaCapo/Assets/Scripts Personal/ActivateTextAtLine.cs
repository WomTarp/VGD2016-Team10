using UnityEngine;
using System.Collections;

public class ActivateTextAtLine : MonoBehaviour {

    public TextAsset theText;

    public int startLine;
    public int endLine;
    public int endLine2;

    public TextBoxManager tBox;

    public bool continueText;
    public bool destroyWhenActivated;
    public bool requiredButtonPress;
    private bool waitForPress;

	// Use this for initialization
	void Start () {
        tBox = FindObjectOfType<TextBoxManager>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (waitForPress && Input.GetKeyDown(KeyCode.Z))
        {
            tBox.ReloadScripts(theText);
            tBox.currentLine = startLine;
            if (continueText) tBox.endAtLine = endLine2;
            else tBox.endAtLine = endLine;
            tBox.EnableTextBox();

            if (destroyWhenActivated) Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter")
        {
            if (requiredButtonPress)
            {
                waitForPress = true;
                return;
            }

            tBox.ReloadScripts(theText);
            tBox.currentLine = startLine;
            tBox.endAtLine = endLine;
            tBox.EnableTextBox();

            if (destroyWhenActivated) Destroy(gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "MainCharacter") waitForPress = false;
    }
}
