using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private Rigidbody2D playerBody;
    public bool canMove;
    public bool canInventory;
    public bool canExamine;

    public Animator anim;

    private KeyCode moveUp = KeyCode.UpArrow;
    private KeyCode moveDown = KeyCode.DownArrow;
    private KeyCode moveLeft = KeyCode.LeftArrow;
    private KeyCode moveRight = KeyCode.RightArrow;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("Up", true);
        canInventory = true;
        canMove = true;
        canExamine = true;
    }

    void Update()
    {
        if (!canMove)
        {
            playerBody.velocity = new Vector2(0, 0);
            return;
        }

        if ((Input.GetKey(moveRight))
         && !(Input.GetKey(moveUp))
         && !(Input.GetKey(moveLeft))
         && !(Input.GetKey(moveDown)))
        {
            playerBody.AddForce(Vector2.right * speed);
            anim.SetBool("Right", true);
            anim.SetBool("Left", false);
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("WalkRight", true);
        }
        else anim.SetBool("WalkRight", false);

        if ((Input.GetKey(moveLeft))
         && !(Input.GetKey(moveUp))
         && !(Input.GetKey(moveDown))
         && !(Input.GetKey(moveRight)))
        {
            playerBody.AddForce(Vector2.left * speed);
            anim.SetBool("Left", true);
            anim.SetBool("Right", false);
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("WalkLeft", true);
        }
        else anim.SetBool("WalkLeft", false);

        if ((Input.GetKey(moveUp))
         && !(Input.GetKey(moveDown))
         && !(Input.GetKey(moveLeft))
         && !(Input.GetKey(moveRight)))
        {
            playerBody.AddForce(Vector2.up * speed);
            anim.SetBool("Up", true);
            anim.SetBool("Down", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
            anim.SetBool("WalkUp", true);
        }
        else anim.SetBool("WalkUp", false);

        if ((Input.GetKey(moveDown))
         && !(Input.GetKey(moveUp))
         && !(Input.GetKey(moveRight))
         && !(Input.GetKey(moveLeft)))
        {
            playerBody.AddForce(Vector2.down * speed);
            anim.SetBool("Down", true);
            anim.SetBool("Left", false);
            anim.SetBool("Up", false);
            anim.SetBool("Right", false);
            anim.SetBool("WalkDown", true);
        }
        else anim.SetBool("WalkDown", false);
    }
}