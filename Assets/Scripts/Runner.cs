using UnityEngine;

public class Runner : MonoBehaviour
{
    bool isMoving = false;
    bool notMoving;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Is Moving");
        if (isMoving == true)
        { 
            transform.position += Vector3.right * speed * Time.deltaTime;
            notMoving = false;
        }
        Debug.Log("Isn't Moving");
        if (notMoving == true)
        {
            isMoving = false;
        }
    }
    public void OnMoveClick()
    {
        isMoving = true;
    }
    public void OnStopClick()
    {
        notMoving = true;
    }
}
