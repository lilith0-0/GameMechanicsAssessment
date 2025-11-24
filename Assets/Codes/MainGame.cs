using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGame : MonoBehaviour
{
	
	public int GObjectsCollected = 0;
	public int GObjectsRequired = 4;
	public bool AnxietyRitualRead = false;

	
	public int PicturesCollected = 0;
	public int PicturesRequired = 5;

	
	public bool CurrentRoomTaskDone
	{
		get
		{
			string scene = SceneManager.GetActiveScene().name;

			if (scene == "AnxietyRoom")
				return GObjectsCollected >= GObjectsRequired;

			if (scene == "FearRoom")
				return PicturesCollected >= PicturesRequired;

			return false;
		}
	}
}

