using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountStunts : MonoBehaviour
{
	SpriteRenderer sr; //the square sprite in the world
	public int howManyStunts = 0;
	public TextMeshProUGUI stunts;


	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		sr = GetComponent<SpriteRenderer>();
		//make the text able to be updated
		stunts.text = howManyStunts.ToString();
	}

    // Update is called once per frame
    void Update()
    {
		
    }
	public void AddStuntNumber()
	{
	//add to the number value of the text when function called (by button)
		howManyStunts += 1;
		stunts.text = howManyStunts.ToString(); // (x,y)
	}
}
