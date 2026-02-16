using UnityEngine;
using UnityEngine.UI; // Required when using UI elements

public class PositionController : MonoBehaviour
{
//This script causes the slider to adjust the Comic Bubble's y position based on its value
	// Reference to the Slider component (optional, can also be linked in the Inspector)
	public Slider positionSlider;

	// Function to be called by the slider's On Value Changed event
	public void SetPositionX(float value)
	{
		// Get the current position
		Vector3 currentPosition = transform.position;

		// Update the axis with the slider's value
		currentPosition.y = value;

		// Set the new position
		transform.position = currentPosition;
	}
}
