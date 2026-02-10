using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelAim : MonoBehaviour
{
    Vector3 barrelRot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mouse pos
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //direction based on sprite position and mouse position
        Vector2 direction = mousePos - transform.position;

        //set transform.up direction to equal that 
        transform.right = direction;

        barrelRot = transform.eulerAngles;
        Mathf.Clamp(barrelRot.z, 0, 180);
      
    }
}
