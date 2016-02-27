using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private Rigidbody2D playerBody;
    public bool canMove;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!canMove)
        {
            playerBody.velocity = new Vector2(0, 0);
            return;
        }

        if ((Input.GetKey(KeyCode.D))
         && !(Input.GetKey(KeyCode.W))
         && !(Input.GetKey(KeyCode.A))
         && !(Input.GetKey(KeyCode.S)))
        {
            playerBody.AddForce(Vector2.right * speed);

        }
        if ((Input.GetKey(KeyCode.A))
         && !(Input.GetKey(KeyCode.W))
         && !(Input.GetKey(KeyCode.D))
         && !(Input.GetKey(KeyCode.S)))
        {
            playerBody.AddForce(Vector2.left * speed);
        }
        if ((Input.GetKey(KeyCode.W))
         && !(Input.GetKey(KeyCode.D))
         && !(Input.GetKey(KeyCode.A))
         && !(Input.GetKey(KeyCode.S)))
        {
            playerBody.AddForce(Vector2.up * speed);
        }
        if ((Input.GetKey(KeyCode.S))
         && !(Input.GetKey(KeyCode.W))
         && !(Input.GetKey(KeyCode.A))
         && !(Input.GetKey(KeyCode.D)))
        {
            playerBody.AddForce(Vector2.down * speed);
        }
    }
}