using System;
using TMPro;
using UnityEngine;

public class DoofusScore : MonoBehaviour
{
    private int[] pulpitsVisitedIds;

    public int score = 0;

    public TextMeshProUGUI scoreText;

    void OnTriggerEnter(Collider crash)
    {
        Debug.Log(true);
    }

    void Update()
    {
        scoreText.text = String.Format("Score {0}", score);
    }
}
