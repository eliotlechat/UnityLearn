using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager_L5 : MonoBehaviour
{
    [SerializeField] GameObject[] ballPrefabs;
    float spawnPosY = 18;
    float spawnLimitX = 18;
    private float startDelay = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(1.5f, 5.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomBall()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnLimitX, spawnLimitX), spawnPosY, 0);
        Instantiate(ballPrefabs[Random.Range(0,ballPrefabs.Length)],spawnPos, ballPrefabs[0].transform.rotation);   
        
    }
}
