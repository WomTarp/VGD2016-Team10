using UnityEngine;
using System.Collections;

public class playerAnimation : MonoBehaviour
{

    public Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.A))
        && !(Input.GetKey(KeyCode.W))
        && !(Input.GetKey(KeyCode.D))
        && !(Input.GetKey(KeyCode.S)))
        {
            anim.SetBool("Left", true);
            anim.SetBool("Right", false);
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
        }

        if ((Input.GetKey(KeyCode.D))
        && !(Input.GetKey(KeyCode.W))
        && !(Input.GetKey(KeyCode.A))
        && !(Input.GetKey(KeyCode.S)))
        {
            anim.SetBool("Right", true);
            anim.SetBool("Left", false);
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
        }

        if ((Input.GetKey(KeyCode.W))
        && !(Input.GetKey(KeyCode.A))
        && !(Input.GetKey(KeyCode.D))
        && !(Input.GetKey(KeyCode.S)))
        {
            anim.SetBool("Up", true);
            anim.SetBool("Down", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }

        if ((Input.GetKey(KeyCode.S))
        && !(Input.GetKey(KeyCode.W))
        && !(Input.GetKey(KeyCode.D))
        && !(Input.GetKey(KeyCode.A)))
        {
            anim.SetBool("Down", true);
            anim.SetBool("Left", false);
            anim.SetBool("Up", false);
            anim.SetBool("Right", false);
        }

        if ((Input.GetKey(KeyCode.A))
        && !(Input.GetKey(KeyCode.W))
        && !(Input.GetKey(KeyCode.D))
        && !(Input.GetKey(KeyCode.S)))
            anim.SetBool("WalkLeft", true);
        else
            anim.SetBool("WalkLeft", false);

        if ((Input.GetKey(KeyCode.D))
        && !(Input.GetKey(KeyCode.W))
        && !(Input.GetKey(KeyCode.A))
        && !(Input.GetKey(KeyCode.S)))
            anim.SetBool("WalkRight", true);
        else
            anim.SetBool("WalkRight", false);

        if ((Input.GetKey(KeyCode.W))
        && !(Input.GetKey(KeyCode.A))
        && !(Input.GetKey(KeyCode.D))
        && !(Input.GetKey(KeyCode.S)))
            anim.SetBool("WalkUp", true);
        else
            anim.SetBool("WalkUp", false);

        if ((Input.GetKey(KeyCode.S))
        && !(Input.GetKey(KeyCode.W))
        && !(Input.GetKey(KeyCode.D))
        && !(Input.GetKey(KeyCode.A)))
            anim.SetBool("WalkDown", true);
        else
            anim.SetBool("WalkDown", false);
    }
}