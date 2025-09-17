/*
  David Huerta
  Challenge 2
 spawns a random ball from the array
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    public float leftX = -22f;
    public float rightX = 7f;
    public float topY = 30f;

    public float startDelay = 1f;

    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    void SpawnRandomBall()
    {
        if (GameManagerX.Instance != null && GameManagerX.Instance.gameOver)
        {
            return; 
        }

        int index = Random.Range(0, ballPrefabs.Length);
        float xPos = Random.Range(leftX, rightX);
        Vector3 spawnPos = new Vector3(xPos, topY, 0f);

        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);

        float nextTime = Random.Range(3f, 5f);
        Invoke("SpawnRandomBall", nextTime);
    }
}
