/*
  David Huerta
  Challenge 2
  this makes the dog run left
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed = 12f;

    void Update()
    {
        // Move LEFT only, in world space (no Z movement)
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);

        // (Safety) Lock Z so it never drifts toward/away from camera
        Vector3 p = transform.position;
        p.z = 0f;                // set this to whatever your gameplay plane is
        transform.position = p;
    }
}

