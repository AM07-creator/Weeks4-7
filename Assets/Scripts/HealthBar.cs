using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public SpriteRenderer player;
    public int health = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        //get mousePos
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //is it inside sprite and are they clicking button?
        if (player.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            //Y: take 1 off health
            health -= 1;
            if (health <= 0)
            {
                gameObject.SetActive(false);
            }
        }
        //update the health bar with new health value
        healthBar.value = health;
    }
    public void Heal()
    {
        //turn on player gameobject
        gameObject.SetActive (true);
        //set health back to 5
        health = (int)healthBar.maxValue;
		//set the value of slider to health
		healthBar.value = health;
	}

}
