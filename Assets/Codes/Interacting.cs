using UnityEngine;

public class Interacting : MonoBehaviour
{
	public enum InteractionType { Positive, Negative, Collectible, RitualNote}
	public InteractionType type;
	public int emotionalValue = 0; 

	public string innerThought = "";
}
