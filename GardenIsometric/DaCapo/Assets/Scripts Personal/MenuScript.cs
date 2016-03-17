using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuScript : MonoBehaviour
{
    public Canvas quitMenu;
    public Button exitText;

    // Use this for initialization
    void Start()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
    }

    public void ExitPress()
    {
        quitMenu.enabled = true;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(7);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}