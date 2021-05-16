using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _scoreText;
    public static int score;

    // Update is called once per frame
    void Update()
    {
        _scoreText.GetComponent<Text>().text = score + " BOTTLES";
        Debug.Log("Collection of bottles: " + score);
    }
}
