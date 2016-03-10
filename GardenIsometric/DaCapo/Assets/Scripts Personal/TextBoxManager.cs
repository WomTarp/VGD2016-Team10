using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

    public GameObject textBox;

    public Text theText;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;

    public PlayerMovement player;

    public bool isActive;
    public bool stopPlayerMovement;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();

        if (textFile != null) textLines = (textFile.text.Split('\n'));

        if (endAtLine == 0) endAtLine = textLines.Length - 1;

        if (isActive) EnableTextBox();
        else DisableTextBox();
    }

    void Update()
    {
        if (!isActive) return;

        if (currentLine <= endAtLine) theText.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.X)) currentLine++;

        if (currentLine > endAtLine) { theText.text = "";  DisableTextBox(); }
    }

    public void EnableTextBox()
    {
        textBox.SetActive(true);
        isActive = true;
        if (stopPlayerMovement) player.canMove = false;
    }

    public void DisableTextBox()
    {
        textBox.SetActive(false);
        isActive = false;
        player.canMove = true;
        player.canInventory = true;
    }

    public void ReloadScripts(TextAsset t)
    {
        if (t != null)
        {
            textLines = new string[1];
            textLines = (t.text.Split('\n'));
        }
    }
}
