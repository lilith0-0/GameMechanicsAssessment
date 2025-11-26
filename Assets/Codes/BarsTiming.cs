using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarsTiming : MonoBehaviour
{
	public string GameOverLoad = "GameOver";
	public Slider Bar;
	public float increaseRate = 2f;

	void Update()
	{
		Debug.Log("BarsTiming running");

		Bar.value += increaseRate * Time.deltaTime;

		if (Bar.value >= Bar.maxValue)
		{
			SceneManager.LoadScene(GameOverLoad);
		}
	}
}
