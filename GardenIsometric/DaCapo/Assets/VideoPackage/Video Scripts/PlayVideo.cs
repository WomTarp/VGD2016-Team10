using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class PlayVideo : MonoBehaviour
{
    public MovieTexture movie;
    //private AudioSource audio1;

    // Use this for initialization
    public void Start()
    {

        GetComponent<RawImage>().texture = movie as MovieTexture;
        //audio1 = GetComponent<AudioSource>();
        //audio1.clip = movie.audioClip;
        if (!movie.isPlaying)
        {
            // Play clip
            movie.Play();
            // Wait for the clip to finish
            StartCoroutine(Wait(movie.duration, OnWaitFinished));
        
        }
    }

    private void OnWaitFinished()
    {
        SceneManager.LoadScene("Dialogue#1");
    }

    private IEnumerator Wait(float duration, System.Action callback)
    {
        yield return new WaitForSeconds(duration);
        if (callback != null) callback();
    }

    // Update is called once per frame
    public void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space) && movie.isPlaying)
        //{
        //  movie.Pause();
        //}
        // else if (Input.GetKeyDown(KeyCode.Space) && !movie.isPlaying)
        //{
        //     movie.Play();
        //  }
    }
}