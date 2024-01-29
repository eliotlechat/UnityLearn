//using UnityEngine;

//public class SpawnManager_P4_save : MonoBehaviour
//{
//    public GameObject enemyPrefab;
//    public GameObject powerupPrefab;
//    private float spawnRange = 9f;
//    int enemyCount;
//    public int waveNumber = 1;

//    // Start is called before the first frame update
//    private void Start()
//    {
//        SpawnEnemyWave(waveNumber);
//        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
//    }

//    // Update is called once per frame
//    private void Update()
//    {
//        enemyCount = FindObjectsOfType<Enemy_P4>().Length;

//        if (enemyCount == 0)

//        {
//            waveNumber++;
//            SpawnEnemyWave(waveNumber);
//            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
//        }
//    }

//    private Vector3 GenerateSpawnPosition()
//    {
//        float spawnPosX = Random.Range(-spawnRange, spawnRange);
//        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
//        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
//        return spawnPos;
//    }

//    private void SpawnEnemyWave(int enemyToSpawn)
//    {
//        for (int i = 0; i < enemyToSpawn; i++)
//        {
//            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
//        }
//    }


//}