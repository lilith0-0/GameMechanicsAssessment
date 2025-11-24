using UnityEngine;

public class HeadColliderScript : MonoBehaviour
{
	void Start()
	{
		var headCollider = GameObject.FindGameObjectWithTag("HeadCollider").GetComponent<Collider2D>();


		var walls = GameObject.FindGameObjectsWithTag("IgnoreHeadCollider");

		foreach (var wall in walls)
		{
			var col = wall.GetComponent<Collider2D>();
			if (col != null)
			{
				Physics2D.IgnoreCollision(headCollider, col, true);
			}
		}
	}
}