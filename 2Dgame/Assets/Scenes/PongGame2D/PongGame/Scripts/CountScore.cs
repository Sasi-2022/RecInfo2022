using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class CountScore : MonoBehaviour
{
    public TextMeshProUGUI Scoreboard;
    public GameObject ball;
    public static bool canAddScore = true;

    private int Bat1Score = 0;
    private int Bat2Score = 0;
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

   
    void Update()
    {

        if (ball.transform.position.x >= 20f && canAddScore)
        {
            canAddScore = false;
            Bat1Score ++;
        }

        if (ball.transform.position.x <= -20f && canAddScore)
        {
            canAddScore = false;
            Bat2Score ++;
        }

        if (Bat1Score >= 3)
        {
            SceneManager.LoadScene(2);
        } 

        if (Bat2Score >= 3)
        {
            SceneManager.LoadScene(3);
        }

        Scoreboard.text = Bat1Score.ToString() + " - " + Bat2Score.ToString();

       

    }
}
