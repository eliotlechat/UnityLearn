
using UnityEngine;
using TMPro;

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


    private void Start()
    {
        playerRb =  GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        // This is where we get player input
        
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // We move the vehicle forward
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        playerRb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);

        // We turn the vehicle
        transform.Rotate(Vector3.up,turnSpeed * horizontalInput * Time.deltaTime);
        speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 3.6f);
        speedometerText.text = "Speed : " + speed + "km/h";
        rpm = Mathf.Round(speed % 30) * 40;
        rpmText.text = "Rpm : " + rpm; 


    }


}