using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletTravel : MonoBehaviour
{
    public bool leftMouseIsPressed = false;
    public GameObject TankBullet;
    public Transform start;
    public Transform end;
    public float time = 0;
    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //call the barrel aim script
        GetComponent<BarrelAim>();
    }

    // Update is called once per frame
    void Update()
    {
        leftMouseIsPressed = Mouse.current.leftButton.isPressed;

        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(TankBullet);
        }
        //run timer for time: make time bigger
        
        time += Time.deltaTime;
        if (time > 1)
        {
            time = 0;
        }

        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(time));

    }
}
