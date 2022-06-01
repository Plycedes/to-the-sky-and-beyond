using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMobile : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Rigidbody2D rb;

    public float speed = 15f;
    public float mapWidth = 5f;
    public float sideWaysForce = 10f;
    public float sideWaysForce2 = -10f;

    bool pressed = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }

    void Update()
    {
        if (pressed)
            MoveLeft();
    }

    public void MoveLeft()
    {
        
    }

    void OnCollisionEnter2D()
    {
        FindObjectOfType<GameManagement>().EndGame();
    }
}
