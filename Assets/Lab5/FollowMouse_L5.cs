using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse_L5 : MonoBehaviour
{

    public float xBound = 19.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        
        mousePos.y = 2;
        mousePos.z = 0;

        mousePos.x = Mathf.Clamp(mousePos.x, -xBound, xBound);
        transform.position = mousePos;
        
    }

    
}
