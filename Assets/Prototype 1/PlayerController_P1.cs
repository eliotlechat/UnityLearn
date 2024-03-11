
using UnityEngine;
using TMPro;
using System.Collections.Generic;
using Unity.VisualScripting;

public class PlayerController_P1 : MonoBehaviour
{


    [SerializeField] float speed;
    [SerializeField] float rpm;
    [SerializeField] float horsePower = 0.0f;
    Rigidbody playerRb;
    [SerializeField] float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;
    


    private void Start()
    {
        playerRb =  GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

   
    private void FixedUpdate()
    {
        // Get Input from player
        
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        
        if (IsOnGround())
        {
            // We move the vehicle forward
            //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            playerRb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);

            // Truning the vihicle
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

            // print speed
            speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 3.6f);
            speedometerText.text = "Speed : " + speed + "km/h";

            // print RPM
            rpm = Mathf.Round(speed % 30) * 40;
            rpmText.text = "Rpm : " + rpm;
        }
        
           
      

    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;

        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded) 
            {
                wheelsOnGround++;
            }
        }
        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    

    


}