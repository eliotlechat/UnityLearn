using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_BCB : MonoBehaviour
{
    public float speed = 50f;
    private float horizontalInput;
    public float xBound = 19.0f;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // get the user's horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        // move the player from left to right
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        

        

    }

   

}
