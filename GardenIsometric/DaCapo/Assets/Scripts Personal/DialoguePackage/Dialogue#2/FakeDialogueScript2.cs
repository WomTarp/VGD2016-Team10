using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
using System;

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
    public Sprite foyerEmpty;
    public Sprite arnouxUp;
    public Sprite arnouxLeft;
    public Sprite arnouxRight;
    public int pressCount;
    public float speed;
    public Image arnoux;
    public Animator anim;
    public GameObject moreau;
    private Rigidbody2D moreauBody;
    public bool isMoving;

    // Use this for initialization
    void Start()
    {
        pressCount = 0;
        background = background.GetComponent<Image>();
        lines = lines.GetComponent<Text>();
        anim = moreau.GetComponent<Animator>();
        anim.SetBool("right", true);
        moreauBody = moreau.GetComponent<Rigidbody2D>();
        background.sprite = foyerEmpty;
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
            anim.SetBool("right", false);
            anim.SetBool("left", true);
            anim.SetBool("walkLeft", true);
            moreauBody.AddForce(Vector2.left * speed);
            lines.text = line10.ToString();
            isMoving = true;
            StartCoroutine(Wait(2, OnWaitFinished));
        }

        else if (pressCount == 11)
        {
            lines.text = line9a.ToString();
        }

        else if (pressCount == 12)
        {
            lines.text = line9b.ToString();
        }

        else if (pressCount == 13)
        {
            lines.text = line9c.ToString();
        }

        else if (pressCount == 14)
        {
            arnoux.sprite = arnouxRight;
            lines.text = line10.ToString();
        }

        else if (pressCount == 15)
        {
            arnoux.sprite = arnouxUp;
        }

        else if (pressCount == 16)
        {
            arnoux.sprite = arnouxLeft;
            lines.text = line11.ToString();
        }

        else if (pressCount == 17)
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