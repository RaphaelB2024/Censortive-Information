using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public GameObject prefab;
        public int poolSize = 10;
        [HideInInspector] public Queue<GameObject> objects;
    }

    public Pool[] pools;

    public float minX, maxX, minZ, maxZ;
    public float spawnHeight = 15f;

    public float minSpawnTime = 0.5f;
    public float maxSpawnTime = 3.0f;

    private float nextSpawnTime;

    void Start()
    {
        // Initialize object queues
        foreach (Pool pool in pools)
        {
            pool.objects = new Queue<GameObject>();

            for (int i = 0; i < pool.poolSize; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                pool.objects.Enqueue(obj);
            }
        }

        ScheduleNextSpawn();
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            ScheduleNextSpawn();
        }
    }

    void ScheduleNextSpawn()
    {
        nextSpawnTime = Time.time + Random.Range(minSpawnTime, maxSpawnTime);
    }

    void SpawnObject()
    {
        if (pools.Length == 0) return;

        int selection = Random.Range(0, pools.Length);
        Pool selectedPool = pools[selection];

        if (selectedPool.objects.Count == 0)
        {
            Debug.LogWarning("No objects available in pool for: " + selectedPool.prefab.name);
            return;
        }

        GameObject obj = selectedPool.objects.Dequeue();
        Vector3 randomPos = new Vector3(Random.Range(minX, maxX), spawnHeight, Random.Range(minZ, maxZ));

        obj.transform.position = randomPos;
        obj.transform.rotation = Quaternion.Euler(90, 0, 0);
        obj.SetActive(true);

        // Optionally: Re-enqueue after delay or upon custom event
        //StartCoroutine(DisableAndRequeue(obj, selectedPool, 5f)); // Disable after 5 seconds
    }

    IEnumerator DisableAndRequeue(GameObject obj, Pool pool, float delay)
    {
        yield return new WaitForSeconds(delay);
        obj.SetActive(false);
        pool.objects.Enqueue(obj);
    }
}