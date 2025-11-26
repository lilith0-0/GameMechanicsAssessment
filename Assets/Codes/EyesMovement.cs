using UnityEngine;
using UnityEngine;

public class EyeMovement : MonoBehaviour
{
	public Transform character;
	public float Distance = 0.2f;   
	public Vector3 MaxRadius = new Vector3(0.1f, 0.2f, 0.0f);
	public Vector3 startLocalPos;

	void Start()
	{
		startLocalPos = transform.localPosition; 
	}

	void Update()
	{
		Vector3 direction = character.position - transform.position;
		Vector3 newLocalPos = startLocalPos + direction * Distance;
		Vector3 move = newLocalPos - startLocalPos;
		move.x = Mathf.Clamp(move.x, -MaxRadius.x, MaxRadius.x);
		move.y = Mathf.Clamp(move.y, -MaxRadius.y, MaxRadius.y);
		transform.localPosition = startLocalPos + move;
	}
}
