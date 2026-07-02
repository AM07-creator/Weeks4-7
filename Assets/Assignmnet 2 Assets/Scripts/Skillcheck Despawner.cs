using UnityEngine;

public class SkillcheckDespawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		//Safe guard if a skill check is not interacted with. (Skillcheck isn't attempted) The skillcheck will disappear after four seconds of spawning. A new Skillcheck will spawn on top of this one
		Destroy(gameObject, 4);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
