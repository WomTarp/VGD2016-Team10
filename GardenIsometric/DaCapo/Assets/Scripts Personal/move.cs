using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode moveLeft;
    public KeyCode moveRight;

    void Start()
    {

    }


    void FixedUpdate()
    {
          if (Input.GetKey(moveUp))
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 3, 0);
          else if (Input.GetKey(moveDown))
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, -3, 0);
          else if (Input.GetKey(moveLeft))
                GetComponent<Rigidbody2D>().velocity = new Vector3(-3, 0, 0);
          else if (Input.GetKey(moveRight))
                GetComponent<Rigidbody2D>().velocity = new Vector3(3, 0, 0);
          else 
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
    }
}


