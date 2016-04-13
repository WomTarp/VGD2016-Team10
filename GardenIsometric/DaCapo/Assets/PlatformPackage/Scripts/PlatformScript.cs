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
            StartCoroutine(ChangeLevel("Dialogue#2"));
            //UnityEngine.SceneManagement.SceneManager.LoadScene("Dialogue#2");
        }
        if (co.name == "musicSheet1")        //loads to next level 
        {
            StartCoroutine(ChangeLevel("Credits"));
        }
        if (co.name == "musicSheet2")        //loads to next level 
        {
            StartCoroutine(ChangeLevel("Credits"));
        }

        if (co.tag == "notes")             //fills up determination
        {
            SoundWhenCollide.Play();
           
            if (DeterminationSlider.value < 1)
            {
                DeterminationSlider.value += .1f;
            }
            
            co.gameObject.SetActive(false);
        }
    }

    IEnumerator ChangeLevel(string sceneName)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        GetComponent<Rigidbody2D>().gravityScale = 0;
        float fadeTime = GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
