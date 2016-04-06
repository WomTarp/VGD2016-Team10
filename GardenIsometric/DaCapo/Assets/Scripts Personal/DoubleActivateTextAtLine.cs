using UnityEngine;
using System.Collections;

public class DoubleActivateTextAtLine : ActivateTextAtLine {

    //public TextAsset theText;

    //public int startLine;
    //public int endLine;
    //public int endLine2;

    public int startLine2;
    public int endLineB;
    public int endLineB2;

    public CheckItem check1;
    public CheckItem check2;

    //public TextBoxManager tBox;

    //public bool continueText;
    //public bool destroyWhenActivated;
    //public bool requiredButtonPress;
    //private bool waitForPress;
    //private bool textBoxActivated;
    //private bool discontinueText;
    public bool nextText;
    public int getItem;

    // Use this for initialization
    void Start()
    {
        check1.enabled = true;
        check2.enabled = false;
        getItem = 0;
        nextText = false;
        tBox = FindObjectOfType<TextBoxManager>();
        textBoxActivated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (waitForPress && Input.GetKeyDown(KeyCode.Z) && !textBoxActivated && tBox.player.canExamine && !discontinueText)
        {
            textBoxActivated = true;
            tBox.player.anim.SetBool("WalkRight", false);
            tBox.player.anim.SetBool("WalkUp", false);
            tBox.player.anim.SetBool("WalkDown", false);
            tBox.player.anim.SetBool("WalkLeft", false);
            tBox.player.canInventory = false;
            tBox.finishedText = false;
            tBox.ReloadScripts(theText);
            tBox.currentLine = startLine;
            if (continueText) tBox.endAtLine = endLine2;
            else tBox.endAtLine = endLine;
            tBox.EnableTextBox();

            if (destroyWhenActivated && continueText)
            {
                if (getItem == 1) discontinueText = true;
                else
                {
                    startLine = startLine2;
                    endLine = endLineB;
                    endLine2 = endLineB2;
                    check2.enabled = true;
                    check2.waitForPress = true;
                    continueText = check2.inv.CheckIfItemIsInInventory(check2.itemCheckValue);
                    check1.enabled = false;
                    nextText = false;
                    getItem = 1;
                }
            }
        }
        if (tBox.currentLine > tBox.endAtLine)
        {
            textBoxActivated = false;
            tBox.player.canInventory = true;
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
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "MainCharacter") waitForPress = false;
    }
}
