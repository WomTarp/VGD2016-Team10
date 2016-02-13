using UnityEngine;
using System.Collections;

public class textbubble : MonoBehaviour {
    //bool display = false;
    /* public GameObject canvas;

     void Start()
     {
        canvas.SetActive(false); 
     }

     void OnTriggerEnter2D(Collider2D co)
     {
         if (co.name == "char_girl")
             canvas.SetActive(false);
     }


     void OnTriggerExit2D(Collider2D co)
     {
         if (co.name == "char_girl")
             canvas.SetActive(false);
     }
     */


    public GameObject plate;
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag == "Player")
        {
            //gameObject.SetActive(false);
            plate.gameObject.SetActive(true);
        }

    }

    void OnTriggerExit2D(Collider2D co)
    {
        if (co.tag == "Player")
        {
            plate.gameObject.SetActive(false);
        }
    }
}


