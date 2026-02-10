using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class TankInput : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Keyboard.current.leftArrowKey.isPressed == true)
        {
            Vector2 newPosition = transform.position;
            newPosition.x -= speed * Time.deltaTime;
            transform.position = newPosition;
        }
      if (Keyboard.current.rightArrowKey.isPressed == true)
        {
            Vector2 newPosition = transform.position;
            newPosition.x += speed * Time.deltaTime;
            transform.position = newPosition;
        }
    }
}
