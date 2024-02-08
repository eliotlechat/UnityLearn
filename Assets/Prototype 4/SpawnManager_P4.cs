using UnityEngine;
using UnityEngine.VFX;

public class SpawnManager_P4 : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    private float spawnRange = 9f;
    int enemyCount;
    public int waveNumber = 1;

    private void Start()
    {
        SpawnEnemyWave(waveNumber); //ca spawn une vague avec un nombre défini d'ennemies et on utilise une loop pour ca, je sais pas pk

        Instantiate(powerupPrefab,GenerateSpawnPosition(),powerupPrefab.transform.rotation);

    }

    private void Update()

        
    {
        enemyCount = FindObjectsOfType<Enemy_P4>().Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
    }


    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }











}