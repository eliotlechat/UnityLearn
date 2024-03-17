using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeOnClick : MonoBehaviour
{

    public MeshRenderer Renderer;
    public float timeToChange = 0.1f;

    private Material material;
    // Start is called before the first frame update
    void Start()
    {
        material = Renderer.material;
        InvokeRepeating("ChangeColor", 2f, 2f);

        //material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
        material.color = new Color(Random.value, Random.value, Random.value, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeColor()
    {
        material.color = new Color(Random.value, Random.value, Random.value, 1f);
    }
}
