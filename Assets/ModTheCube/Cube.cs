using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public float timeToChange = 0.1f;
    private float timeSinceChange = 0f;
    private Material material;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        material = Renderer.material;

        InvokeRepeating("ChangeColor", 2f, 2f);
        
        //material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
        material.color = new Color(Random.value, Random.value, Random.value, 1f);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    void ChangeColor()
    {
        material.color = new Color(Random.value, Random.value, Random.value, 1f);
    }
}
