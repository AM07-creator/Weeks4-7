using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class BirbHouse : MonoBehaviour
{
    public GameObject birb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            //Instantiate(birb, transform.position, Quaternion.identity);
            Vector2 spawnPos = Random.insideUnitCircle * 6;
            Instantiate(birb, spawnPos, Quaternion.identity);
        }
    }
}
