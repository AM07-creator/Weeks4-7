using UnityEngine;
using UnityEngine.InputSystem;

public class RandomColor : MonoBehaviour
{
    public SpriteRenderer colorMe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void changeColor()
    {
            colorMe.color = Random.ColorHSV();
    }
}
