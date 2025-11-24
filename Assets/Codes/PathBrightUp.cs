using UnityEngine;

public class PathLightTrigger : MonoBehaviour
{
	public SpriteRenderer pathSprite;
	public float fadeSpeed = 2f;

	private float targetAlpha = 0f; 

	void Start()
	{
		
		if (pathSprite != null)
		{
			Color c = pathSprite.color;
			c.a = 0f;
			pathSprite.color = c;
		}
	}

	void Update()
	{
		if (pathSprite == null) return;

		Color c = pathSprite.color;
		c.a = Mathf.Lerp(c.a, targetAlpha, fadeSpeed * Time.deltaTime);
		pathSprite.color = c;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			targetAlpha = 1f; 
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			targetAlpha = 0f; 
		}
	}
}
