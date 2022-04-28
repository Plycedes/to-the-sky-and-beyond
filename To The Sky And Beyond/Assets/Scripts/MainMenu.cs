using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
        FindObjectOfType<AudioManager>().Play("menuClick");
    }
}
