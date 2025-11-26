using UnityEngine;
using UnityEngine.UI;

public class RoomDarking : MonoBehaviour
{
	public Slider Bar;
	public Image DarknessOverlay;

	void Update()
	{
		float darknessAmount = Bar.value / Bar.maxValue;

		Color colour = DarknessOverlay.color;
		colour.a = darknessAmount;
		DarknessOverlay.color = colour;
	}
}
