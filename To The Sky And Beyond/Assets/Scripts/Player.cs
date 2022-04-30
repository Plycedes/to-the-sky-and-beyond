using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 15f;

    public float mapWidth = 5f;

    public float sideWaysForce = 10f;
    public float sideWaysForce2 = -10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);      

        rb.MovePosition(newPosition);
    }

    void OnCollisionEnter2D()
    {
        FindObjectOfType<GameManagement>().EndGame();
    }

    public void Left()
    {
        rb.AddForce(transform.right * sideWaysForce2, ForceMode2D.Force);
    }

    public void Right()
    {

        rb.AddForce(transform.right * sideWaysForce, ForceMode2D.Force);
        
    }
}
