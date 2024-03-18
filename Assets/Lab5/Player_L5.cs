using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Unity.VisualScripting.StickyNote;
using Unity.VisualScripting;

public class Player_L5 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private int score;
    private int scoreToAdd = 5;
    
    Color ballColorCaught;
    Color BasketColor;
    bool BasketColorIsCorrect;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore(0);
    }


    private void OnTriggerEnter(Collider other)
    {
        ballColorCaught = other.GetComponent<Renderer>().material.color;

        GetBallColor();

        GetBasketColor();

        IsSameColor();

        if (BasketColorIsCorrect == true)
        {
            UpdateScore(scoreToAdd);
        }
        
    }

    void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score : " + score;
    }

    void GetBallColor()
    {
        if (ballColorCaught == Color.blue)
        {
            Debug.Log("Ball Color : blue ");
        }

        if (ballColorCaught == Color.green)
        {
            Debug.Log("Ball Color : green ");
        }

        if (ballColorCaught == Color.red)
        {
            Debug.Log("Ball Color : red");
        }
    }

    void GetBasketColor()
    {
        BasketColor = GetComponent<Renderer>().material.color;
      
        if (BasketColor == Color.blue)
        {
            Debug.Log("Basket Color : blue ");
        }

        if (BasketColor == Color.green)
        {
            Debug.Log("Basket Color : green ");
        }

        if (BasketColor == Color.red)
        {
            Debug.Log("Basket Color : red");
        }
    }

    void IsSameColor()
    {
        if (ballColorCaught == Color.blue && BasketColor == Color.blue)
        {
            Debug.Log("BasketColorIsCorrect = true");
            BasketColorIsCorrect = true;
        }

        if (ballColorCaught == Color.green && BasketColor == Color.green)
        {
            Debug.Log("BasketColorIsCorrect = true");
            BasketColorIsCorrect = true;

        }

        if (ballColorCaught == Color.red && BasketColor == Color.red)
        {
            Debug.Log("BasketColorIsCorrect = true");
            BasketColorIsCorrect = true;
        }
    }

}
