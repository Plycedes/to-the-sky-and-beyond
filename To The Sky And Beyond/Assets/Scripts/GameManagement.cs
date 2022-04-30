using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public float timeStoneEffect = 10f;    

    public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }


    //We will need System.Collection to use the IEnumerator function type.
    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / timeStoneEffect;
        //fixedDeltaTime also needs to be slowed by the same time slowing factor i.e. 10f.
        Time.fixedDeltaTime = Time.fixedDeltaTime / timeStoneEffect;

        //since time is being slowed down by 10 times of its original value, we need to wait for 10 times less than 1 sec to
        //to wait for 1 sec.
        yield return new WaitForSeconds(1f / timeStoneEffect);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * timeStoneEffect;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
