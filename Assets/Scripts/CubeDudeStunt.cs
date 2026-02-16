using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CubeDudeStunt : MonoBehaviour
{
	public float speed = 5.0f;
	public GameObject cubeDudePrefab;
	public Transform spawnPoint;
	public float t;
	private GameObject currentInstance;
	//public Transform start;
	//public Transform end;
	public AnimationCurve curve;

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
		//t += Time.deltaTime;
		//if (t > 3)
		//{
		//	t = 0;
		//}
		//transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
	}
	public void SpawnCubeDude()
	{
		// Destroy the previous instance if it exists (only happens if the button has been pressed once already, effectively deleting CubeDude and respawning him somewhere new with a new random rotation
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