using System.Threading;
using UnityEngine;

public class TimedFloorSpikes : MonoBehaviour
{
    public float timer = 0f;
    public float activeTimer = 0f;
    public GameObject spikeTrap;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Set the timer to 3 seconds and to activate the spike trap upon the timer resetting
        timer += Time.deltaTime;
        if(timer > 3)
        {
            timer = 0;
            Instantiate(spikeTrap);
        }
    }
}
