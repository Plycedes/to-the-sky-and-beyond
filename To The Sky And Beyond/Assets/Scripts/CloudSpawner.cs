using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject cloudPrefab;

    public float timeBetweenWaves = 1f;
    private float timeToSpawn = 2f;

    void Update()
    {
        if(Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(cloudPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }      
    }    
}
