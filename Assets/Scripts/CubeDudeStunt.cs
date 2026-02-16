using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CubeDudeStunt : MonoBehaviour
{
//This script controls where CubeDude can spawn and respawn, as well as how he spawns and respawns, and automatically clicks the button after a timer ends
	public float speed = 5.0f;
	public GameObject cubeDudePrefab;
	public Transform spawnPoint;
	public float t = 0f;
	private GameObject currentInstance;
	public Button targetButton;

	Vector2 bottomLeft;
	Vector2 topRight;

	void Start()
	{
		// World space boundaries for spawning CubeDude
		bottomLeft = Camera.main.ScreenToWorldPoint(Vector2.zero);
		topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
	}
	void Update()
	{
		t += Time.deltaTime;
		if (t > 3)
		{
		// Automatically clicks the button after 3 second timer ends
			targetButton.onClick.Invoke();
			t = 0;
		}

	}
	public void SpawnCubeDude()
	{
		// Destroy the previous CubeDude if it exists (only happens if the button has been pressed once already, effectively deleting CubeDude and respawning him somewhere new with a new random rotation
		if (currentInstance != null)
		{
			Destroy(currentInstance);
		}

		// Generate random rotation
		float randomZ = Random.Range(0f, 360f);
		Quaternion randomRotation = Quaternion.Euler(0, 0, randomZ);

		// Generate random position in unit circle 
		Vector2 randomCirclePos = Random.insideUnitCircle * 5;
		Vector3 spawnPos = new Vector3(randomCirclePos.x, randomCirclePos.y, 0) + spawnPoint.position;

		// Instantiate the prefab
		currentInstance = Instantiate(cubeDudePrefab, spawnPos, randomRotation);
	}
}