using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountStunts : MonoBehaviour
{

//This script is used to add the number of stunts performed (button clicks) in the little comic speech bubble, as well as grabbing the CubeDudeStunt script to allow you to click a key and stunt without adding to the text box
	SpriteRenderer sr; //the square sprite in the world
	public int howManyStunts = 0;
	public TextMeshProUGUI stunts;
	public GameObject spawnerObject;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		sr = GetComponent<SpriteRenderer>();
		//make the text able to be updated
		stunts.text = howManyStunts.ToString();
	}

	// Update is called once per frame
	void Update()
	{ //press r to make CubeDude perform a stunt without it being tracked on the UI
		if (Input.GetKeyDown(KeyCode.R))
		{
			// Use GetComponent to get CubeDudeStunt
			CubeDudeStunt spawnerScript = spawnerObject.GetComponent<CubeDudeStunt>();

			if (spawnerScript != null)
			{
				spawnerScript.SpawnCubeDude();
			}
		}
	}
	public void AddStuntNumber()
	{
	//add to the number value of the text when function called (by button)
		howManyStunts += 1;
		stunts.text = howManyStunts.ToString(); // (x,y)
	}
}
