/*
  David Huerta
  Challenge 2
 destroys ball when dog touches it
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            
            GameManagerX.Instance.AddScore(1);

            
            Destroy(other.gameObject);
        }
    }
}
