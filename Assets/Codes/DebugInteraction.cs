using UnityEngine;

public class DebugInteraction : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Trigger ENTER: " + other.name);
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		Debug.Log("Trigger EXIT: " + other.name);
	}
}