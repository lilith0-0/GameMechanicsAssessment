using UnityEngine;

public class SpiderTrigger : MonoBehaviour
{
	public SpiderRun spider;
	private bool IsTriggered = false;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (IsTriggered) return;

		if (other.CompareTag("Player"))
		{
			spider.Activate();
			IsTriggered = true;
			var characterInteract = other.GetComponent<CharacterInteract>();

			characterInteract.DialogueBox.SetActive(true);
			characterInteract.DialogueText.text = "Something runs across... A SPIDER";
			characterInteract.FearBar.value += 10;
		}
	}
}