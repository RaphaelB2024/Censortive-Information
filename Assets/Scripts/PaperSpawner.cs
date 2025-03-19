using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperSpawner : MonoBehaviour
{
    //Create public array of objects to spawn
    public GameObject[] objectsToSpawn;

    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    float timeTillSpawn;            //Length to wait before spawning new object
    float timeSinceSpawn = 0.0f;    //Time since last object was spawned

    public float minSpawnTime = 0.5f; //Minimum time between spawns
    public float maxSpawnTime = 3.0f; //Maximum time between spawns


    // Start is called before the first frame update
    void Start()
    {
        //random range between two values
        timeTillSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        //Add time passed since last frame
        //this creates a float counting up in seconds
        timeSinceSpawn = timeSinceSpawn + Time.deltaTime;

        //if time has passed amount to wait,
        if (timeSinceSpawn > timeTillSpawn)
        {
            int selection = Random.Range(0, objectsToSpawn.Length);

            //Assign a random spawnpoint to the paper
            Vector3 randompos = new Vector3(Random.Range(minX, maxX), 15, Random.Range(minZ, maxZ));

            //Instantiate spawns a gameObject - this case from objectsToSpawn
            //second parameter is where to spawn
            //third parameter is rotation, Quarternion.identity means no rotation
            Instantiate(objectsToSpawn[selection], randompos, Quaternion.Euler( new Vector3(90,0,0)));

            //After spawn, timer is reset and a new time until spawn is selected
            timeTillSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            timeSinceSpawn = 0.0f;
        }
    }
}
