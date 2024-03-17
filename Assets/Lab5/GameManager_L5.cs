using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager_L5 : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    
    public int pointValue;



    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score : " + score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Une balle a touché le panier");
        UpdateScore(pointValue);
    }



    // Si il y a quelque chose dans le CollisionEnter, on ajoute des points au ScoreText
}
