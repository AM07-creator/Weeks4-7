using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Trainer : MonoBehaviour
{
    public SpriteRenderer johnPork;
    public Camera gameCam;
    public Color caughtColor;

    public List<SpriteRenderer> uncaughtPorks;
    public List<SpriteRenderer> caughtPorks;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool isClicked = Mouse.current.leftButton.wasPressedThisFrame;


        Vector3 mousePos = Mouse.current.position.ReadValue();
        Vector3 worldMousePos = gameCam.ScreenToWorldPoint(mousePos);
        worldMousePos.z = 0f;

        if (isClicked)
        {
            //caughtCreatures:
            //for each element I want to output that to the console

            //FIRST SECTION: Define and set the value of the iterator
            //SECOND SECTION: Define how long loop will run
            //THIRD SECTION: Increase the value of i each time it loops
            for (int i = 0; i < caughtPorks.Count; )
            {
                Debug.Log(caughtPorks[i]);
            }


            if (caughtPorks.Count > 0)
            {
                Debug.Log(caughtPorks[0]);
            }

            if (isClicked && johnPork.bounds.Contains(worldMousePos))
            {
                Debug.Log("Caught John Pork");
                johnPork.color = caughtColor;

                bool isPorkCaught = caughtPorks.Contains(johnPork);
                Debug.Log("Is Pork Caught[" + isPorkCaught.ToString() + "]");
                if (!caughtPorks.Contains(johnPork))
                {
                    caughtPorks.Add(johnPork);
                }
                uncaughtPorks.Remove(johnPork);
            }
        }
    }
}
