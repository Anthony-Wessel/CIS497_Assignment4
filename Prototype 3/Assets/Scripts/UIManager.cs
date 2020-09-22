using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    bool won = false;

    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerController == null)
        {
            playerController = FindObjectOfType<PlayerController>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerController.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        if (playerController.gameOver && !won)
        {
            scoreText.text = "You Lose!\nPress R to try again.";
        }
        if (score >= 10)
        {
            playerController.gameOver = true;
            won = true;
            scoreText.text = "You Win!\nPress R to play again.";
        }

        if (playerController.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
