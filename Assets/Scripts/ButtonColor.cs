using UnityEngine;

public class ButtonColor : MonoBehaviour
{
    public SpriteRenderer square;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetRandomColor()
    {
		Color color = Random.ColorHSV();
        square.color = color;
    }
}
