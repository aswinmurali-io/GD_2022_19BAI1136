using TMPro;
using UnityEngine;

public class PulpitsAutoDestory : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro timerText;

    [SerializeField]
    private DoofusScore doofusScore;

    private void Start()
    {
        var pulpitData = DoofusDiaryDataComponent.data.pulpitData;
        var randomDestroyTime = Random.Range((float)pulpitData.minDestroyTime, (float)pulpitData.maxDestroyTime);

        Debug.Log($"Pulpits ({gameObject.GetInstanceID()}) has destroy time set to {randomDestroyTime} seconds");
        Invoke("Die", randomDestroyTime);
    }

    private void Die()
    {
        gameObject.SetActive(false);
        doofusScore.score += 1;
    }
}
