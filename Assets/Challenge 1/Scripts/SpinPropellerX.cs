using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    float rotationSpeed = 10000f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed*Time.deltaTime);
    }
}
