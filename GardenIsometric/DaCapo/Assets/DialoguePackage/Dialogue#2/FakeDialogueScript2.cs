using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FakeDialogueScript2 : MonoBehaviour
{
    public Image background;
    public Text lines;
    public TextAsset line0;
    public TextAsset line1;
    public TextAsset line2;
    public TextAsset line3a;
    public TextAsset line3b;
    public TextAsset line4;
    public TextAsset line5;
    public TextAsset line6;
    public TextAsset line7;
    public TextAsset line8;
    public TextAsset line9a;
    public TextAsset line9b;
    public TextAsset line9c;
    public TextAsset line10;
    public TextAsset line11;
    public Sprite foyerChat;
    public Sprite foyerAlone;
    public Sprite foyerLeft;
    public Sprite foyerRight;
    public int pressCount;

    // Use this for initialization
    void Start()
    {
        pressCount = 0;
        background = background.GetComponent<Image>();
        lines = lines.GetComponent<Text>();
        background.sprite = foyerChat;
        lines.text = line0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            pressCount++;
            nextLine();
        }
    }

    void nextLine()
    {
        if (pressCount == 1)
        {
            lines.text = line1.ToString(); ;

        }

        else if (pressCount == 2)
        {
            lines.text = line2.ToString(); ;
        }

        else if (pressCount == 3)
        {
            lines.text = line3a.ToString(); ;
        }

        else if (pressCount == 4)
        {
            lines.text = line3b.ToString(); ;
        }

        else if (pressCount == 5)
        {
            lines.text = line4.ToString(); ;
        }

        else if (pressCount == 6)
        {
            lines.text = line5.ToString(); ;
        }

        else if (pressCount == 7)
        {
            lines.text = line6.ToString(); ;
        }

        else if (pressCount == 8)
        {
            lines.text = line7.ToString(); ;
        }

        else if (pressCount == 9)
        {
            lines.text = line8.ToString();
        }

        else if (pressCount == 10)
        {
            background.sprite = foyerAlone;
            lines.text = line9a.ToString();
        }

        else if (pressCount == 11)
        {
            lines.text = line9b.ToString();
        }

        else if (pressCount == 12)
        {
            lines.text = line9c.ToString();
        }

        else if (pressCount == 13)
        {
            background.sprite = foyerRight;
            lines.text = line10.ToString();
        }

        else if (pressCount == 14)
        {
            background.sprite = foyerLeft;
        }

        else if (pressCount == 15)
        {
            background.sprite = foyerAlone;
            lines.text = line11.ToString();
        }

        else if (pressCount == 16)
        {
            SceneManager.LoadScene("Interior");
        }
    }
}