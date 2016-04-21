using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
using System;

public class FakeDialogueScript3 : MonoBehaviour
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
    public TextAsset line10;
    public TextAsset line11;
    public TextAsset line12;
    public TextAsset line13;
    public TextAsset line14;
    public Sprite patio;
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
        background.sprite = patio;
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
            lines.text = line10.ToString();
        }

        else if (pressCount == 11)
        {
            lines.text = line11.ToString();
        }

        else if (pressCount == 12)
        {
            lines.text = line12.ToString();
        }

        else if (pressCount == 13)
        {
            lines.text = line13.ToString();
            moreauBody.AddForce(Vector2.up * speed);
            isMoving = true;
            StartCoroutine(Wait(2, OnWaitFinished));
        }

        else if (pressCount == 14)
        {
            lines.text = line14.ToString();
        }

        else if (pressCount == 15)
        {
            SceneManager.LoadScene("RearGarden");
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