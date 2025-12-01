using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DoorOpen : MonoBehaviour
{
	public string NextScene = "FearRoom";
	public GameObject DialogueBox;
	public TextMeshProUGUI DialogueText;
	private bool inReach = false;

	private void OnTriggerEnter2D(Collider2D other)
	{
		inReach = true;
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		inReach = false;
	}

	void Update()
	{
		if (!inReach) return;

		if (Input.GetKeyDown(KeyCode.F))
		{
			var mainGame = FindObjectOfType<MainGame>();
			if (mainGame == null)
			{
				SceneManager.LoadScene(NextScene);
			}

			if (!mainGame.TaskDone)
			{
				DialogueBox.SetActive(true);
				DialogueText.text = "The door won't open yet.";
			}
			else
			{
				DialogueBox.SetActive(true);
				DialogueText.text = "I'm escaping this room.";
				SceneManager.LoadScene(NextScene);
			}

			if (DialogueBox.activeSelf && Input.GetKeyDown(KeyCode.Period))
			{
				DialogueBox.SetActive(false);
			}
		}
	}
}




