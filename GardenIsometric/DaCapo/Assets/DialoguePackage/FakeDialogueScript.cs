using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FakeDialogueScript : MonoBehaviour
{
    public Text instruction;
    public Image background;
    public Text lines;
    public TextAsset line1;
    public TextAsset line2;
    public TextAsset line3;
    public TextAsset line4;
    public TextAsset line5;
    public TextAsset line6;
    public TextAsset line7;
    public TextAsset line8;
    public TextAsset line9;
    public Sprite doorOpen;
    public Sprite doorClosed;
    public int lineCount;
    
    // Use this for initialization
	void Start ()
    {
        lineCount = 1;
        instruction = instruction.GetComponent<Text>();
        background = background.GetComponent<Image>();
        lines = lines.GetComponent<Text>();
        background.sprite = doorOpen;
        lines.text = line1.ToString();
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
            instruction.enabled = false;
            lines.text = line2.ToString(); ;
            
        }

        else if (lineCount == 3)
        {
            lines.text = line3.ToString(); ;
        }

        else if (lineCount == 4)
        {
            lines.text = line4.ToString(); ;
        }

        else if (lineCount == 5)
        {
            lines.text = line5.ToString(); ;
        }
        
        else if (lineCount == 6)
        {
            lines.text = line6.ToString(); ;
        }

        else if (lineCount == 7)
        {
            lines.text = line7.ToString(); ;
        }

        else if (lineCount == 8)
        {
            lines.text = line8.ToString(); ;
            background.sprite = doorClosed;
        }

        else if (lineCount == 9)
        {
            lines.text = line9.ToString(); ;
        }

        else if (lineCount == 10)
        {
            SceneManager.LoadScene("Exterior");
        }
    }
}
