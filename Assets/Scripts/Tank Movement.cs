using UnityEngine;
using UnityEngine.InputSystem;

public class TankMovement : MonoBehaviour
{
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isLeftHeld = Keyboard.current.leftArrowKey.isPressed;
        if (isLeftHeld == true)
        {
            transform.eulerAngles -= transform.right * speed * Time.deltaTime;
        }
        bool isRightHeld = Keyboard.current.rightArrowKey.isPressed;
        if (isRightHeld == true)
        {
            transform.eulerAngles += transform.right * speed * Time.deltaTime;
        }
    }
}
