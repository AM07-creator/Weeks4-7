using UnityEngine;
//Added UI Namespaces
using UnityEngine.UI;
using TMPro;

public class SkillcheckOutcomeDetection : MonoBehaviour
{
	//Variable Declarations
	public GameObject successZone;
	public GameObject tick;
	TextMeshProUGUI score;
	Slider rotationSpeed;
	Button skillcheckPrompt;
	bool isOverSuccessZone = false;
	bool isOverNothing = true;
	public float speed = 10f;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//Rotate tick overtime
		Vector3 tickRotation = transform.eulerAngles;
		tickRotation.z -= speed * Time.deltaTime;
		transform.eulerAngles = tickRotation;
		//If Tick hits z rotation limit
		if (tickRotation.z == 0.01)
		{
			GetComponent<SkillcheckDespawner>();
		}
		//If Tick is over success zone


		//If button was pressed or Space key was pressed

	}
}
