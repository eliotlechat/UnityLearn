using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30f;
    private PlayerContoller_P3 playerContoller_P3;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        playerContoller_P3 = GameObject.Find("Player").GetComponent<PlayerContoller_P3>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerContoller_P3.gameOver==false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
