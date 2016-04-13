using UnityEngine;
using System.Collections;

public class PickUpFade : MonoBehaviour {

    public GetItem gItem;
    public ActivateTextAtLine aText;
    private bool doChange;
    private bool entered;

    void Start()
    {
        aText = GetComponentInChildren<ActivateTextAtLine>();
        gItem = GetComponentInChildren<GetItem>();
        entered = false;
    }

    void Update()
    {
        if (gItem.doChangeScene && entered && aText.tBox.finishedText)
        {
            StartCoroutine(ChangeLevel(gItem.sceneToChange));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter") entered = true;
    }  

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "MainCharacter") entered = false;
    }

    IEnumerator ChangeLevel(string sceneName)
    {
        float fadeTime = GameObject.Find("MainCharacter").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
