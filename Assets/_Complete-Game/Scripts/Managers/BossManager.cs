﻿using UnityEngine;

namespace CompleteProject
{
    public class BossManager : MonoBehaviour
    {
        public PlayerHealth playerHealth;       // Reference to the player's heatlh.
        public GameObject bossFab;                // The enemy prefab to be spawned.
        public float spawnTime = 3f;            // How long between each spawn.
        public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
        ScoreManager scoreObject;
        [SerializeField] int bossTriggerScore = 20;
        int numberOfBosses = 1;


        [SerializeField] GameObject roomCentreFab; //the prefab for the room centre object
 
        [SerializeField] Transform roomCentrePoint; //the transform for the room centre object


        void Start()
        {
            scoreObject = GameObject.FindObjectOfType<ScoreManager>();
        }

        private void Update()
        {
            if(scoreObject.getScore() > bossTriggerScore && numberOfBosses > 0)
            {
                Spawn();
                numberOfBosses = 0;
                Debug.Log("Spawned boss");
            }
        }

        void Spawn()
        {
            // If the player has no health left...
            if (playerHealth.currentHealth <= 0f)
            {
                // ... exit the function.
                return;
            }

            // Find a random index between zero and one less than the number of spawn points.
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            
            // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
            Instantiate(bossFab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

            //Create instances of roomChoice prefabs and spawn at the chosen location
            Instantiate(roomCentreFab, roomCentrePoint.position, roomCentrePoint.rotation);
        }
    }
}