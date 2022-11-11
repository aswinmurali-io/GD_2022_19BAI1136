using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoofusScore : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    public int score = 0;

    private void Update() => scoreText.text = $"Score {score}";
}
