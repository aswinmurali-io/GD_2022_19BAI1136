using TMPro;
using UnityEngine;
using Zenject;

public class DoofusScoreComponent : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    [Inject]
    private IDoofusScore doofusScore;

    private void Update()
    {
        Debug.Log(doofusScore.Score);

        if (doofusScore != null)
        {
            scoreText.text = $"Score {doofusScore.Score}";
        }
    }
}
