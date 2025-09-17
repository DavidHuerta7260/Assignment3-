/*
  David Huerta
  Challenge 2
  makes balls fall down
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownX : MonoBehaviour
{
    public float speed = 12f;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
