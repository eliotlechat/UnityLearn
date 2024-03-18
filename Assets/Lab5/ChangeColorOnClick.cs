using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChangeColorOnClick : MonoBehaviour
{

    Color[] colorSelection = new Color[] { Color.blue, Color.green, Color.red };
    int currentIndex = 0;

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            ChangeColor();
        }

    }

    private void ChangeColor()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = colorSelection[currentIndex];

        currentIndex = (currentIndex+1) % colorSelection.Length;
    }
}


