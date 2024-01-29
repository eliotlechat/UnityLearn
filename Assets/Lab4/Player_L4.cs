using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player_L4 : MonoBehaviour
{
    
    
    private Rigidbody playerRb;
    public int speed = 20;
    // Start is called before the first frame update
    public float zBound = 5.5f;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
        ConstraintPlayerBound();
        
    }

    void ConstraintPlayerBound()
    {
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
    }
}
