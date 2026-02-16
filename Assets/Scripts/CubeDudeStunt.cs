using UnityEngine;
using UnityEngine.InputSystem;

public class CubeDudeStunt : MonoBehaviour
{
    // This script will be used to controle the button's effects. When pressed, it will make the CubeDude Prefab respawn at a random screenspace position and EulerAngle

    public GameObject cubeDudePrefab;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 spawnPos = Random.insideUnitCircle * 3;
        Instantiate(cubeDudePrefab, transform.position, transform.rotation);
    }
}
