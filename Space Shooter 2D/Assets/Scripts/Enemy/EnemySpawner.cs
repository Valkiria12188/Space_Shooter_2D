using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] asteroidObjects;
    public GameObject enemyShipObject;
    private float minX_Spawn_Position = -7f;
    private float maxX_Spawn_Position = 7f;
   

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemySpawn", 3f, 2f);
    }

   

    void EnemySpawn()
    {
        float rangeSpawn = Random.Range(minX_Spawn_Position, maxX_Spawn_Position);
        Vector3 spawnPosition = transform.position;
        spawnPosition.x = rangeSpawn;

        if (Random.Range(0, 3) > 0)
        {
            var clone = Instantiate(asteroidObjects[Random.Range(0, asteroidObjects.Length)], spawnPosition, Quaternion.identity);
            Destroy(clone, 6f);
        }
        else
        {
            var clone = Instantiate(enemyShipObject, spawnPosition, Quaternion.identity);
            Destroy(clone, 6f);
        }


    }
}
