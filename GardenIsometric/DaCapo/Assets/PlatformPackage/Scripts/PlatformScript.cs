using UnityEngine;
using System.Collections;

public class PlatformScript : MonoBehaviour
{
    public UnityEngine.UI.Slider DeterminationSlider;
    public AudioSource SoundWhenCollide;
    public Vector2 jumpForce = new Vector2(0, 300);
    public float speed = 3;
    
    void Start()
    {      
        // Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    void FixedUpdate()
    {
        // Jump
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
    }

    void OnTriggerEnter2D(Collider2D co)
    {

        if (co.name == "musicSheet0")        //loads to next level 
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Interior");
        }
        if (co.name == "musicSheet1")        //loads to next level 
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Credits");
        }
        if (co.name == "musicSheet2")        //loads to next level 
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Credits");
        }

        if (co.tag == "notes")             //fills up determination
        {
            SoundWhenCollide.Play();
           
            if (DeterminationSlider.value < 1)
            {
                DeterminationSlider.value += .03f;
            }
            
            co.gameObject.SetActive(false);
        }


    }
}
