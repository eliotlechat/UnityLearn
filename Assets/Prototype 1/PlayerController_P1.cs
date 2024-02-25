
using UnityEngine;

public class PlayerController_P1 : MonoBehaviour
{
    // Private variables
   
    [SerializeField] float speed = 5.0f;
    [SerializeField] float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    private void FixedUpdate()
    {
        // This is where we get player input
        
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // We turn the vehicle
        transform.Rotate(Vector3.up,turnSpeed * horizontalInput * Time.deltaTime);

    }


}