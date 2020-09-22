/*
 * Anthony Wessel
 * Assignment 4 Challenge 3
 * Updates the score text and end game text
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static int score;
    public bool won;

    PlayerControllerX player;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerControllerX>();
        score = 0;
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.gameOver)
        {
            if (score >= 10)
            {
                won = true;
                player.gameOver = true;
            }
        }

        if (player.gameOver)
        {
            if (won)
            {
                scoreText.text = "You win!\nPress R to play again!";
            }
            else
            {
                scoreText.text = "You lose!\nPress R to try again!";
            }
            if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            scoreText.text = "Score: " + score;
        }
    }
}
