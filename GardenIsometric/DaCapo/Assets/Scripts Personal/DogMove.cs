using UnityEngine;
using System.Collections;

public class DogMove : MonoBehaviour {

    public Transform movePoint;
    public bool canMove;
    public float speed;
    public TextBoxManager tBox;
    public bool addDescription;
    public Animator anim;

    void Start () {
        movePoint = GameObject.Find("DogMovePoint").transform;
        tBox = GameObject.Find("TextBoxManager").GetComponent<TextBoxManager>();
        anim = GetComponent<Animator>();
        anim.SetBool("right", true);
        canMove = false;
        addDescription = false;
	}

    void FixedUpdate()
    {
        if (transform.position != movePoint.position && canMove && !tBox.isActive)
        {
            Vector2 move = Vector2.MoveTowards(transform.position, movePoint.position, speed);
            anim.SetBool("walkRight", true);
            GetComponent<Rigidbody2D>().MovePosition(move);
        }

        if (transform.position == movePoint.position)
        {
            canMove = false;
            anim.SetBool("walkRight", false);
            GetComponent<Collider2D>().isTrigger = false;
            addDescription = true;
        }
    }
}
