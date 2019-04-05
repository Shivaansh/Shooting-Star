using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Items;                // The enemy prefab to be spawned.
    public float spawnTime = 1f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.


    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        Invoke("Spawn", spawnTime);
    }


    void Spawn()
    {
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex;

        for (int i = 0; i < Items.Length; i++)
        {
            spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(Items[i], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.

    }
}