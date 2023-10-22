using UnityEngine;

public class Simple2DMovement : MonoBehaviour
{
    public float moveSpeed =5f;
    private Rigidbody2D rb;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput =0f;

        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1f;
        }
        

        Vector2 movement = new Vector2(horizontalInput*moveSpeed, rb.velocity.y);
        rb.velocity = movement;
    }
}
