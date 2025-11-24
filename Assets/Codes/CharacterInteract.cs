using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CharacterInteract : MonoBehaviour
{
	public Slider AnxietyBar;
	public Slider FearBar;
	public GameObject DialogueBox;
	public TextMeshProUGUI DialogueText;

	private Interacting currentItem; 

	private bool inReach = false;

	private void OnTriggerEnter2D(Collider2D other)
	{
		var item = other.GetComponent<Interacting>();
		if (item != null)
		{
			inReach = true;
			currentItem = item;
		}
	}


	private void OnTriggerExit2D(Collider2D other)
	{
		var item = other.GetComponent<Interacting>();
		if (item == currentItem)
		{
			inReach = false;
			currentItem = null;
		}
	}
	void Update()
	{
		if (inReach && currentItem != null && Input.GetKeyDown(KeyCode.F))
		{
			DialogueBox.SetActive(true);
			DialogueText.text = currentItem.innerThought;

		
			switch (currentItem.type)
			{
				case Interacting.InteractionType.Positive:
					if (AnxietyBar != null) AnxietyBar.value -= currentItem.emotionalValue;
					if (FearBar != null) FearBar.value += currentItem.emotionalValue;
					break;

				case Interacting.InteractionType.Negative:
					if (AnxietyBar != null) AnxietyBar.value += currentItem.emotionalValue;
					if (FearBar != null) FearBar.value -= currentItem.emotionalValue;
					break;

				case Interacting.InteractionType.Collectible:
					var mainGame = FindObjectOfType<MainGame>();
					string scene = SceneManager.GetActiveScene().name;

					if (scene == "AnxietyRoom")
					{
						if (!mainGame.AnxietyRitualRead)
						{
							DialogueBox.SetActive(true);
							DialogueText.text = "I don't understand this yet...";
							break;
						}

						mainGame.GObjectsCollected++;
						DialogueBox.SetActive(true);
						DialogueText.text = currentItem.innerThought;
						Destroy(currentItem.gameObject);
					}

					else if (scene == "FearRoom")
					{
						mainGame.PicturesCollected++;
						DialogueBox.SetActive(true);
						DialogueText.text = currentItem.innerThought;
						Destroy(currentItem.gameObject);
					}

					break;

				case Interacting.InteractionType.RitualNote:
					DialogueBox.SetActive(true);
					DialogueText.text = currentItem.innerThought;

					var mg = FindObjectOfType<MainGame>();
					string sc = SceneManager.GetActiveScene().name;

					if (sc == "AnxietyRoom")
						mg.AnxietyRitualRead = true;

					break;

			}
		}
		if (DialogueBox.activeSelf && Input.GetKeyDown(KeyCode.Period))
		{
			DialogueBox.SetActive(false);
		}

	}

	
	
}

