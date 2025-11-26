using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MirrorAssult : MonoBehaviour
{
	public string[] mirrorLines;
	public GameObject DialogueBox;
	public Slider FearBar;
	public TextMeshProUGUI DialogueText;

	private bool inReach = false;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
			inReach = true;
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
			inReach = false;
	}

	void Update()
	{
		if (inReach && Input.GetKeyDown(KeyCode.F))
		{
			int randomLine = Random.Range(0, mirrorLines.Length);

			DialogueBox.SetActive(true);
			DialogueText.text = mirrorLines[randomLine];
			FearBar.value += 10;
		}

		if (DialogueBox.activeSelf && Input.GetKeyDown(KeyCode.Period))
		{
			DialogueBox.SetActive(false);
		}
	}
}
