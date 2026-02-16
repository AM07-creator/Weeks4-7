using UnityEngine;
using UnityEngine.UI;

public class CubeDudeStunt : MonoBehaviour
{
    // This script will be used to controle the button's effects. When pressed, it will make the CubeDude Prefab respawn at a random screenspace position and EulerAngle. The Prefab will automatically disappear after a few seconds via timer

    public GameObject cubeDudePrefab;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnCubeDude()
    {
		Vector2 spawnPos = Random.insideUnitCircle * 3;
		Instantiate(cubeDudePrefab, transform.position, transform.rotation);
	}
}
