using UnityEngine;

public class PlayerMobile : MonoBehaviour
{
    private Rigidbody2D rb;

    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    public float speed = 5;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveLeft = false;
        moveRight = false;
    }

    public void PointerDownLeft()
    {
        moveLeft = true;
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    public void PointerDownRight()
    {
        moveRight = true;
    }

    public void PointerUpRight()
    {
        moveRight= false;
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -speed;
        }
        else if (moveRight)
        {
            horizontalMove = speed;
        }
        else
        {
            horizontalMove = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }

    void OnCollisionEnter2D()
    {
        FindObjectOfType<GameManagement>().EndGame();
    }
}
