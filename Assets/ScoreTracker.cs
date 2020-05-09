using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
	public GameObject player;
	public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = PillScript.points.ToString();
    }
}
