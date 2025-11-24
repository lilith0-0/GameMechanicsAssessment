using UnityEngine;

public class SpiderRun : MonoBehaviour
{
	public Transform targetPoint;
	public float speed = 3f;
	private bool run = false;

	void Update()
	{
		if (run)
		{
			transform.position = Vector2.MoveTowards(
				transform.position,
				targetPoint.position,
				speed * Time.deltaTime);
		}
	}

	public void Activate()
	{
		run = true;
	}
}
