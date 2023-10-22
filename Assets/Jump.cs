using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    bool OnGround;
    public float JumpForce = 25f;

    // Start is called before the first frame update
    void Start()
    {
        OnGround = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && OnGround)
        {
            rb.AddForce(Vector2.up * JumpForce);
        
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            OnGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            OnGround = false;
        }
    }
}