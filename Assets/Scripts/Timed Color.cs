using UnityEngine;

public class TimedColor : MonoBehaviour
{
    public SpriteRenderer randomColor;
    public float t;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
            randomColor.color = Random.ColorHSV();
        }
    }
}
