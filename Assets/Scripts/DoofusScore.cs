using TMPro;
using UnityEngine;

public class DoofusScore : MonoBehaviour
{
    public int score = 0;

    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = System.String.Format("Score {0}", score);
    }
}
