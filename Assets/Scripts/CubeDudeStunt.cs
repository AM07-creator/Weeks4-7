using UnityEngine;
using UnityEngine.UI;

public class CubeDudeStunt : MonoBehaviour
{
    // This script will be used to controle the button's effects. When pressed, it will make the CubeDude Prefab respawn at a random position in the unit circle and random EulerAngle. The Prefab will automatically disappear after a few seconds via timer

    public float speed = 0.01f;
    public GameObject cubeDudePrefab;
    public Transform spawnPoint;

    Vector2 bottomLeft;
    Vector2 topRight;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        //world space for CubeDude to spawn/respawn in
        bottomLeft = Camera.main.ScreenToWorldPoint(Vector2.zero);
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnCubeDude()
    {
		// local variable for rotation
		float randomZ = Random.Range(0f, 360f);
		// pick a random z rotation
		Quaternion randomRotation = Quaternion.Euler(0, 0, randomZ);
        //instantiate the prefab transform pos and random z rotation
        Vector2 spawnPos = Random.insideUnitCircle * 5;
		Instantiate(cubeDudePrefab, spawnPos, randomRotation);
	}
}
