using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;    

    void Update()
    {
        scoreText.text = Time.timeSinceLevelLoad.ToString("0");
    }
}
