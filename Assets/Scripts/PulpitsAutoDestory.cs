using UnityEngine;

public class PulpitsAutoDestory : MonoBehaviour
{
    public GameObject gameSystem;

    private DoofusDiaryDataComponent diaryComponent;

    private bool messageLock = false;

    void Start()
    {
        diaryComponent = gameSystem.GetComponent<DoofusDiaryDataComponent>();
    }

    void Die()
    {
        Destroy(gameObject);
        enabled = false;
    }

    void Update()
    {
        if (!diaryComponent.DiaryFound("PulpitsAutoDestory")) return;

        var minDestroyTime = diaryComponent.diaryData.pulpitData.minPulpitDestroyTime;
        var maxDestroyTime = diaryComponent.diaryData.pulpitData.maxPulpitDestroyTime;

        var randomDestroyTime = Random.Range(minDestroyTime, maxDestroyTime);

        if (!messageLock)
        {
            Debug.Log(System.String.Format("Pulpits ({0}) has destroy time set to {1} seconds", this.gameObject.GetInstanceID(), randomDestroyTime));
            messageLock = true;
        }

        Invoke("Die", randomDestroyTime);
    }
}
