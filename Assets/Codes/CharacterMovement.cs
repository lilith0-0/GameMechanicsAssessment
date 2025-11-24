using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public Sprite Forward;
    public Sprite Back;
    public Sprite left;
    public Sprite Right;

    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Vector2 move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        
        if (move.x > 0)
        {
            spriteRenderer.sprite = Right;
        }
        else if (move.x < 0)
        {
            spriteRenderer.sprite = left;
        }
        else if (move.y > 0)
        {
            spriteRenderer.sprite = Back;
        }
        else if (move.y < 0)
        {
            spriteRenderer.sprite = Forward;
        }
    }
    void FixedUpdate()
{
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);

       
    }
}

