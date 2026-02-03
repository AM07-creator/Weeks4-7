using UnityEngine;

public class Toggle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleShape()
    {
        gameObject.SetActive(gameObject.activeInHierarchy);

        //gameObject.SetActive(false);
        //if gameobject is inactive: call SetActive passing true
        //if (gameObject.activeInHierarchy == false)
        //{
        //    gameObject.SetActive(true);
        //}
        //else if(gameObject.activeInHierarchy == true)
        //{
        //    //otherwise gameobject is active: call setactive and call false
        //    gameObject.SetActive(false);
        //}
    }
}
