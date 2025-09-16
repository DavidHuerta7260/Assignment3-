/*
David Huerta
Prototype 2
shows display counter
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;

    public int score = 0;

    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    void Update()
    {
        textbox.text = "Score: " + score;
    }
}
