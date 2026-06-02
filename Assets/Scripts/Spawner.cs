using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject runnerPrefab;
    public Vector3 spawnPosition;
    public GameObject existingRunner;
    public float spawnSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            Destroy(existingRunner, 3f);
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            

            //Spawn a runner!
            //Instantiate(runnerPrefab);

            //Spawn a runner that is a child of this object

            //Instantiate(runnerPrefab, transform);

            //spawn a runner at a specific position w/ no rotation
            //GameObject spawnedObject = Instantiate(runnerPrefab, transform.position, Quaternion.identity);

            //SpriteRenderer spawnedSpriteRenderer = spawnedObject.GetComponent<SpriteRenderer>();
            //spawnedSpriteRenderer.color = Color.red;

            ////Make the spawned object move at the spawner speed
            //Runner spawnedRunner = spawnedObject.GetComponent<Runner>();
            //if (spawnedRunner != null)
            //{
            //    spawnedRunner.speed = spawnSpeed;
            //}

            //Destroy(spawnedObject, 2f);
        }
    }
    void OnSpawnPress()
    {

    }
}
