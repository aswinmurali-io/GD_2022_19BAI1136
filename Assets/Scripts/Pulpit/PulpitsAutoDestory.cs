using TMPro;
using UnityEngine;

public class PulpitsAutoDestory : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro timerText;

    [SerializeField]
    private DoofusScore doofusScore;

    private bool lockUpdate;

    private void OnEnable()
    {
        lockUpdate = false;
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (DoofusDiaryDataComponent.data == null) return;

        if (!lockUpdate)
        {
            lockUpdate = true;
            var pulpitData = DoofusDiaryDataComponent.data.pulpitData;
            var randomDestroyTime = Random.Range((float)pulpitData.minDestroyTime, (float)pulpitData.maxDestroyTime);

            Debug.Log($"Pulpits ({gameObject.GetInstanceID()}) has destroy time set to {randomDestroyTime} seconds");
            Invoke("Die", randomDestroyTime);
        }
    }
}
