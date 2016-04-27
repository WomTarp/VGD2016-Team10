using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Determination : MonoBehaviour
{
    public Slider DeterminationSlider;  
    public Text gameOverText;   
    public Button leave;
    public Button stay;
    public GameObject player;
    private bool isGameOver = false; 

    void Start()
    {

        gameOverText.enabled = false; 
        leave.gameObject.SetActive(false);
        stay.gameObject.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D co)
    {
        if (co.tag == "edge")
        {   if (DeterminationSlider.value > 0)
            {
                DeterminationSlider.value -= .0025f;  //reduce determination
            }
              
            else
            {
                isGameOver = true;                  
                gameOverText.enabled = true; 
                leave.gameObject.SetActive(true);
                stay.gameObject.SetActive(true);
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
                GetComponent<Rigidbody2D>().gravityScale = 0;
            }
        }
    }
}