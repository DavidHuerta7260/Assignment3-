/*
  David Huerta
  Challenge 2
 spacebar spawning dog and cooldown for dog
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldown = 1.25f;
    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && timer >= cooldown)
        {
            if (GameManagerX.Instance != null && !GameManagerX.Instance.gameOver)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timer = 0f;
            }
        }
    }
}
