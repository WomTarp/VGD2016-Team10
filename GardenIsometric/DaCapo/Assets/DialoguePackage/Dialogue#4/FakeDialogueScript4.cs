using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
using System;

public class FakeDialogueScript4 : MonoBehaviour
{
    public Image background;
    public Text lines;
    public TextAsset line0;
    public TextAsset line1;
    public TextAsset line2;
    public TextAsset line3;
    public TextAsset line4;
    public TextAsset line5;
    public TextAsset line6;
    public TextAsset line7;
    public TextAsset line8;
    public TextAsset line9;
    public TextAsset line9b;
    public TextAsset line10;
    public TextAsset line11;
    public TextAsset line12;
    public TextAsset line13;
    public TextAsset line14;
    public TextAsset line15;
    public TextAsset line16;
    public TextAsset line17;
    public TextAsset line18;
    public TextAsset line19;
    public TextAsset line20;
    public TextAsset line21;
    public TextAsset line22;
    public TextAsset line22b;
    public TextAsset line23;
    public TextAsset line24;
    public TextAsset line25;
    public TextAsset line26;
    public TextAsset line27;
    public TextAsset line28;
    public TextAsset line29;
    public TextAsset line29b;
    public TextAsset line30;
    public TextAsset line31;
    public TextAsset line32;
    public TextAsset line33;
    public Sprite emptyFoyer;
    public Sprite arnouxUp;
    public int pressCount;
    public float speed;
    public Image arnoux;
    public GameObject moreau;
    private Rigidbody2D moreauBody;
    public bool isMoving;

    // Use this for initialization
    void Start()
    {
        pressCount = 0;
        background = background.GetComponent<Image>();
        lines = lines.GetComponent<Text>();
        moreauBody = moreau.GetComponent<Rigidbody2D>();
        background.sprite = emptyFoyer;
        lines.text = line0.ToString();
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                pressCount++;
                nextLine();
            }
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
            lines.text = line3.ToString(); ;
        }

        else if (pressCount == 4)
        {
            lines.text = line4.ToString(); ;
        }

        else if (pressCount == 5)
        {
            lines.text = line5.ToString(); ;
        }

        else if (pressCount == 6)
        {
            lines.text = line6.ToString(); ;
        }

        else if (pressCount == 7)
        {
            lines.text = line7.ToString(); ;
        }

        else if (pressCount == 8)
        {
            lines.text = line8.ToString(); ;
        }

        else if (pressCount == 9)
        {
            lines.text = line9.ToString();
        }

        else if (pressCount == 10)
        {
            lines.text = line9b.ToString();
        }

        else if (pressCount == 11)
        {
            lines.text = line10.ToString();
        }

        else if (pressCount == 12)
        {
            lines.text = line11.ToString();
        }

        else if (pressCount == 13)
        {
            lines.text = line12.ToString();
        }

        else if (pressCount == 14)
        {
            lines.text = line13.ToString();
        }

        else if (pressCount == 15)
        {
            lines.text = line14.ToString();
        }

        else if (pressCount == 16)
        {
            lines.text = line15.ToString();
        }

        else if (pressCount == 17)
        {
            lines.text = line16.ToString();
        }

        else if (pressCount == 18)
        {
            lines.text = line17.ToString(); ;

        }

        else if (pressCount == 19)
        {
            lines.text = line18.ToString(); ;
        }

        else if (pressCount == 20)
        {
            lines.text = line19.ToString(); ;
        }

        else if (pressCount == 21)
        {
            lines.text = line20.ToString(); ;
        }

        else if (pressCount == 22)
        {
            lines.text = line21.ToString(); ;
        }

        else if (pressCount == 23)
        {
            lines.text = line22.ToString(); ;
        }

        else if (pressCount == 24)
        {
            lines.text = line22b.ToString(); ;
        }

        else if (pressCount == 25)
        {
            lines.text = line23.ToString(); ;
        }

        else if (pressCount == 26)
        {
            lines.text = line24.ToString(); ;
        }

        else if (pressCount == 27)
        {
            lines.text = line25.ToString();
        }

        else if (pressCount == 28)
        {
            lines.text = line26.ToString();
        }

        else if (pressCount == 29)
        {
            lines.text = line27.ToString();
        }

        else if (pressCount == 30)
        {
            lines.text = line28.ToString();
        }

        else if (pressCount == 31)
        {
            lines.text = line29.ToString();
        }

        else if (pressCount == 32)
        {
            lines.text = line29b.ToString();
        }

        else if (pressCount == 33)
        {
            lines.text = line30.ToString();
        }

        else if (pressCount == 34)
        {
            lines.text = line31.ToString();
        }

        else if (pressCount == 35)
        {
            lines.text = line32.ToString();
        }

        else if (pressCount == 36)
        {
            lines.text = line33.ToString();
            moreauBody.AddForce(Vector2.up * speed);
            isMoving = true;
            StartCoroutine(Wait(2, OnWaitFinished));
        }

        else if (pressCount == 37)
        {
            SceneManager.LoadScene("Interior");
        }
    }

    private void OnWaitFinished()
    {
        isMoving = false;
    }

    private IEnumerator Wait(float duration, System.Action callback)
    {
        yield return new WaitForSeconds(duration);
        if (callback != null) callback();
    }
}