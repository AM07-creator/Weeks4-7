using System.Threading;
using UnityEngine;

public class TimedTRap : MonoBehaviour
{
    public float timer = 0f;
    public float activeTimer = 0f;
    public bool spikeActive = false;
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
            ////spikeActive = true;
            //activeTimer += Time.deltaTime;
            //Instantiate(spikeTrap);
            //if (activeTimer > 3)
            //{
            //    activeTimer = 0;
            //    Destroy(spikeTrap);
            //}
           
        }
    }
}
