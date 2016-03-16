using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FakeDialogueScript : MonoBehaviour
{
    public Sprite line1;
    public Sprite line2;
    public Sprite line3;
    public Sprite line4;
    public Sprite line5;
    public Sprite line6;
    public Sprite line7;
    public Sprite line8;
    public Sprite line9;
    public Sprite doorOpen;
    public Sprite doorClosed;
    public int lineCount;
    
    // Use this for initialization
	void Start ()
    {
        lineCount = 1;
        GameObject.Find("background").GetComponent<Image>().sprite = doorOpen;
        GameObject.Find("dialogueBox").GetComponent<Image>().sprite = line1;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.X))
        {
            lineCount++;
            nextLine();      
        }
	}

    void nextLine()
    {
        if (lineCount == 2)
        {
            GameObject.Find("dialogueBox").GetComponent<Image>().sprite = line2;
        }

        else if (lineCount == 3)
        {
            GameObject.Find("dialogueBox").GetComponent<Image>().sprite = line3;
        }

        else if (lineCount == 4)
        {
            GameObject.Find("dialogueBox").GetComponent<Image>().sprite = line4;
        }

        else if (lineCount == 5)
        {
            GameObject.Find("dialogueBox").GetComponent<Image>().sprite = line5;
        }
        
        else if (lineCount == 6)
        {
            GameObject.Find("dialogueBox").GetComponent<Image>().sprite = line6;
        }

        else if (lineCount == 7)
        {
            GameObject.Find("dialogueBox").GetComponent<Image>().sprite = line7;
        }

        else if (lineCount == 8)
        {
            GameObject.Find("dialogueBox").GetComponent<Image>().sprite = line8;
            GameObject.Find("background").GetComponent<Image>().sprite = doorClosed;
        }

        else if (lineCount == 9)
        {
            GameObject.Find("dialogueBox").GetComponent<Image>().sprite = line9;
        }

        else if (lineCount == 10)
        {
            SceneManager.LoadScene("Exterior");
        }
    }
}
