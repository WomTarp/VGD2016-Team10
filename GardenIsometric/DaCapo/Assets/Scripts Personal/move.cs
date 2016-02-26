using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    private Rigidbody2D myRigidBody;

    private KeyCode moveUp = KeyCode.UpArrow;
    private KeyCode moveDown = KeyCode.DownArrow;
    private KeyCode moveLeft = KeyCode.LeftArrow;
    private KeyCode moveRight = KeyCode.RightArrow;
    public int speed;

    public bool canMove;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (!canMove)
        {
            myRigidBody.velocity = new Vector2(0, 0);
            return;
        }

        if (Input.GetKey(moveUp))
            myRigidBody.velocity = new Vector2(0, speed);
        else if (Input.GetKey(moveDown))
            myRigidBody.velocity = new Vector2(0, -speed);
        else if (Input.GetKey(moveLeft))
            myRigidBody.velocity = new Vector2(-speed, 0);
        else if (Input.GetKey(moveRight))
            myRigidBody.velocity = new Vector2(speed, 0);
        else
            myRigidBody.velocity = new Vector2(0, 0);
    }
}
