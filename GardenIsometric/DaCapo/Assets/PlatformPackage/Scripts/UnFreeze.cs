using UnityEngine;
using System.Collections;

public class UnFreeze : MonoBehaviour
{

    public GameObject book;

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "StudyPlayer")
        {
            book.GetComponent<Rigidbody2D>().isKinematic = false;
        }
    }
}
