using UnityEngine;

public class BallController : MonoBehaviour
{
    private float speed = 10f;
    private float horizontalInput;
    private float forwardInput;
    public float jumpForce = 2f;
    private Rigidbody rb;
    public bool isOnGround = true;

    private float xRange = 15;
    private float zRange = 10;

    // Start is called before the first frame update

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        MovePlayer();
        ConstraintPlayerPosition();
        Jumping();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

    private void Jumping()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void MovePlayer()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // We move the ball forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // We move the ball vertically
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }

    private void ConstraintPlayerPosition()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }
}