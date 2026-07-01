using UnityEngine;
//Added UI Namespaces
using UnityEngine.UI;
using TMPro;

public class Skillcheck : MonoBehaviour
{
    //Variable Declarations
    GameObject successZone;
    GameObject tick;
    public GameObject skillcheckPrefab;
    public TextMeshProUGUI score;
    public Slider rotationSpeed;
    public Button skillcheckPrompt;
    public bool isOverSuccessZone = false;
    public bool isOverNothing = true;
    public float duration;
    float countUp = 0f;
    public float speed = 1f;
	float despawnCount = 0f;
	public float despawnDuration;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Count up the time to six seconds (duration is set in Unity inspector)
        countUp += Time.deltaTime;
        //If the time is equal to six seconds, reset the timer and spawn a skillcheck prefab
        if(countUp >= duration)
        {
            Debug.Log("Spawned a Skillcheck");
            countUp = 0f;
            Instantiate(skillcheckPrefab);
			despawnCount += Time.deltaTime;
            despawnCount = 0f;
		}

		//Safe guard if a skill check is not interacted with. (Skillcheck isn't attempted) The skillcheck will disappear after four seconds of spawning

		if (despawnCount >= despawnDuration)
		{
			Destroy(skillcheckPrefab);
			Debug.Log("Skillcheck Destroyed");
		}
	}
}
