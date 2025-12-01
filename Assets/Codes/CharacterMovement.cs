using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	public float speed = 5.0f;
	public Sprite Forward;
	public Sprite Back;
	public Sprite Left;
	public Sprite Right;
	public Rigidbody2D rigidBody;
	public SpriteRenderer spriteRenderer;
	public Vector2 move;

	void Start()
	{
		rigidBody = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

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
			spriteRenderer.sprite = Left;
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
		rigidBody.MovePosition(rigidBody.position + move * speed * Time.fixedDeltaTime);
	}
}

