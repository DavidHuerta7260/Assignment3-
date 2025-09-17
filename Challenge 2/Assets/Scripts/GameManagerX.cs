/*
  David Huerta
  Challenge 2
 Manages Score and You Win and GameOver text
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerX : MonoBehaviour
{
    public static GameManagerX Instance;   

    public int score = 0;
    public int health = 5;

    public Text scoreText;
    public Text healthText;
    public Text statusText;

    public bool gameOver = false;

    void Awake()
    {
        
        Instance = this;
    }

    void Start()
    {
        UpdateScoreText();
        UpdateHealthText();
        statusText.text = "";
    }

    void Update()
    {
        
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void AddScore(int amount)
    {
        if (gameOver) return;

        score = score + amount;
        UpdateScoreText();

        if (score >= 5)
        {
            gameOver = true;
            statusText.text = "You Win! Press R to Restart";
        }
    }

    public void LoseHealth(int amount)
    {
        if (gameOver) return;

        health = health - amount;
        if (health < 0) health = 0;
        UpdateHealthText();

        if (health == 0)
        {
            gameOver = true;
            statusText.text = "Game Over! Press R to Restart";
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    void UpdateHealthText()
    {
        healthText.text = "Health: " + health;
    }
}