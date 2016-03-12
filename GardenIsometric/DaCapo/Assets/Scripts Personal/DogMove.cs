using UnityEngine;
using System.Collections;

public class DogMove : MonoBehaviour {

    public Transform movePoint;
    public bool canMove;
    public float speed;
    public TextBoxManager tBox;
    public bool addDescription;

	void Start () {
        movePoint = GameObject.Find("DogMovePoint").transform;
        tBox = GameObject.Find("TextBoxManager").GetComponent<TextBoxManager>();
        canMove = false;
        addDescription = false;
	}

    void FixedUpdate()
    {
        if (transform.position != movePoint.position && canMove && !tBox.isActive)
        {
            Vector2 move = Vector2.MoveTowards(transform.position, movePoint.position, speed);
            GetComponent<Rigidbody2D>().MovePosition(move);
        }

        if (transform.position == movePoint.position)
        {
            canMove = false;
            GetComponent<Collider2D>().isTrigger = false;
            addDescription = true;
        }
    }
}
