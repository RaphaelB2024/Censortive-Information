using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperSpawner : MonoBehaviour
{
    //Create public array of objects to spawn
    public GameObject[] objectsToSpawn;

    public GameObject minX;
    public GameObject minY;
    public GameObject maxX;
    public GameObject maxY;

    float randomx = 0;
    float randomy = 0;

    Vector3 randompos;

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

            //Instantiate spawns a gameObject - this case from objectsToSpawn
            //second parameter is where to spawn
            //third parameter is rotation, Quarternion.identity means no rotation
            Instantiate(objectsToSpawn[selection], randompos, Quaternion.identity);

            //After spawn, timer is reset and a new time until spawn is selected
            timeTillSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            timeSinceSpawn = 0.0f;
            randomx = Random.Range(minX.x, minX.x);
            randomy = Random.Range(minY.y, maxY.y);
            randompos = (randomx, randomy, 0);
        }
    }
}
