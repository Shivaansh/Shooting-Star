using UnityEngine;

namespace CompleteProject
{
    public class BossManager : MonoBehaviour
    {
        public PlayerHealth playerHealth;       // Reference to the player's heatlh.
        public GameObject bossFab;                // The enemy prefab to be spawned.
        public float spawnTime = 3f;            // How long between each spawn.
        public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
        ScoreManager scoreObject;
        [SerializeField] int bossTriggerScore = 500;
        int numberOfBosses = 1;

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
        }
    }
}