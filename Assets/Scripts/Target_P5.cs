using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Target_P5 : MonoBehaviour


{
    Rigidbody targetRb;
    float minSpeed = 12;
    float maxSpeed = 16;
    float maxTorque = 10;
    float rangeX = 4;
    float ySpawnPos = -6;


    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPosition();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        Destroy(gameObject);    
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomSpawnPosition()
    {
        return new Vector3(Random.Range(-rangeX, rangeX), ySpawnPos);
    }

}
