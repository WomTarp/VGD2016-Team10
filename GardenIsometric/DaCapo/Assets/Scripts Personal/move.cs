using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public int speed;

    void Start()
    {
    }


    void FixedUpdate()
    {
          if (Input.GetKey(moveUp))
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
          else if (Input.GetKey(moveDown))
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
          else if (Input.GetKey(moveLeft))
                GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
          else if (Input.GetKey(moveRight))
                GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
          else 
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }
}


