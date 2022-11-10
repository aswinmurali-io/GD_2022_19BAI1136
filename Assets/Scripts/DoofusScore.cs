using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoofusScore : MonoBehaviour
{
    public List<int> pulpitsVisitedIds;

    public int score = 0;

    [SerializeField]
    private TextMeshProUGUI scoreText;

    private void Update() => scoreText.text = String.Format("Score {0}", score);
}
