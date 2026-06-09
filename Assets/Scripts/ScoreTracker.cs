using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    public Slider slider;
    public TMP_Text currentScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnSliderChanged(float scoreValue)
    {
        currentScore.text = "Score " + slider.value;
        //Debug.Log(slider.value);
        Debug.Log(scoreValue);
    }
}
