using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PhotoOverlay : MonoBehaviour
{
	public GameObject Photo_0;
	public GameObject DialogueBox;
	public TextMeshProUGUI DialogueText;
	public string Desciption;
	private bool OverlayOpened = false;

	void Update()
	{
		string scene = SceneManager.GetActiveScene().name;
		var mainGame = FindObjectOfType<MainGame>();
		if (scene == "FearRoom"&&!OverlayOpened)
		{
			if (mainGame.TaskDone)
			{
				Photo_0.SetActive(true);
				DialogueBox.SetActive(true);
				DialogueText.text = Desciption;
				OverlayOpened = true;
			}
			
		}
		if (Photo_0.activeSelf && Input.GetKeyDown(KeyCode.Period))
		{
			Photo_0.SetActive(false);
			DialogueBox.SetActive(false);
		}
	}
}

