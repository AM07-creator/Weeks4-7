using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UiDemo : MonoBehaviour
{
    SpriteRenderer sr; //the square sprite in the world
    public Image duckieImage; //the duckie IMAGE on the UI canvas
    public int howManyClicks = 0;
    public TextMeshProUGUI score;
    public Slider slider;
    public TextMeshProUGUI sliderDisplay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
		score.text = howManyClicks.ToString();
        slider.wholeNumbers = true;
        slider.value = 500;
	}

    // Update is called once per frame
    void Update()
    {
        sliderDisplay.text = slider.value.ToString();
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            ChangeColor();
        }
    }
    public void ChangeColor()
    {
        sr.color = Random.ColorHSV();
        duckieImage.color = sr.color;
    }
    public void SetScale(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }
    public void AddToNumber()
    {
        howManyClicks += 1;
        score.text = howManyClicks.ToString(); // (x,y)
    }
}
