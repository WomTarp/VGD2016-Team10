using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour {

    public void ChangeToScene(int sceneToChangeTo)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToChangeTo);
    }
}
