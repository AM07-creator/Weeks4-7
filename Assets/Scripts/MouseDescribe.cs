using UnityEngine;
using UnityEngine.InputSystem;

public class MouseDescribe : MonoBehaviour
{
    public Camera gameCamera;
    public SpriteRenderer sprite;
	public SpriteRenderer sprite2;
    //bool isRevealed = false;

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

        if(sprite.bounds.Contains(worldMousePosition))
        {
            Debug.Log("IsOver");
        }
		if (sprite2.bounds.Contains(worldMousePosition))
		{
			Debug.Log("IsOver");
		}
	}
    //public void OnHoverReveal()
    //{
    //    bool isRevealed = true;
    //}
}
