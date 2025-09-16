/*
David Huerta
Prototype 2
Destroy gameobject when out of bounds
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;

    public float bottomBound = -10;

    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < bottomBound)
        {
            Debug.Log("Game Over!");

            Destroy(gameObject);
        }
    }
}
