using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEditor;
using UnityEngine;

public class Enemy_P4 : MonoBehaviour
{

    // L'ennemy va suivre le player 
    // playerPosition-EnemyPosition = vecteur

    public float speed = 1.0f;
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);

        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}