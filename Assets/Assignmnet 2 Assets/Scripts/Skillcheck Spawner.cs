using UnityEngine;
//Added UI Namespaces
using UnityEngine.UI;
using TMPro;

public class Skillcheck : MonoBehaviour
{
    //Variable Declarations
    public GameObject skillcheckPrefab;
    public float duration;
    float countUp = 0f;

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
		}
	}
}
