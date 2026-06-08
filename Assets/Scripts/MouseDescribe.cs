using UnityEngine;
using UnityEngine.InputSystem;

public class MouseDescribe : MonoBehaviour
{
    public Camera gameCamera;
    public SpriteRenderer sprite1;
	public SpriteRenderer sprite2;
	bool isOver = false;
    public GameObject text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Track mousePos
		Vector3 mousePosition = Mouse.current.position.ReadValue();
		Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(mousePosition);
		worldMousePosition.z = 0f;

        if(sprite1.bounds.Contains(worldMousePosition))
        {
            Debug.Log("IsOverCassette");
            isOver = true;
        }
		if (sprite2.bounds.Contains(worldMousePosition))
		{
			Debug.Log("IsOverCar");
			isOver = true;
		}
        if(isOver == true)
        {
            //text;
        }
	}
}
