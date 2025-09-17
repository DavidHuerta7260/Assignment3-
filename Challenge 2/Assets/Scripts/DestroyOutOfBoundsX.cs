/*
  David Huerta
  Challenge 2
  removes dogs and balls that go out of bounds
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    public float leftLimit = -30f;
    public float bottomLimit = -5f;

    void Update()
    {
        // destroy dog if it goes too far left
        if (gameObject.CompareTag("Dog") && transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }

        // destroy ball if it goes below the screen
        if (gameObject.CompareTag("Ball") && transform.position.y < bottomLimit)
        {
            // tell game manager we lost health
            GameManagerX.Instance.LoseHealth(1);

            Destroy(gameObject);
        }
    }
}
