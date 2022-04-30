using UnityEngine;

public class Block : MonoBehaviour
{
    public float gravityScaleFactor = 20f;
    public int score;
    

    void Start()
    {
        //Increasing gravity after some time has passed since the level started.
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravityScaleFactor;
    }

    void Update()
    {
        if(transform.position.y < -10)
        {
            Destroy(gameObject);
            score++;        }
               
    }
}
