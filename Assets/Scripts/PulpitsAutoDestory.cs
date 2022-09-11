using UnityEngine;

public class PulpitsAutoDestory : MonoBehaviour
{
    public GameObject gameSystem;

    private DoofusDiaryDataComponent diaryComponent;

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
        if (diaryComponent.diaryData == null)
        {
            Debug.Log("No data in diary found! PulpitsAutoDestory component is waiting...");
            return;
        }

        var minDestroyTime = diaryComponent.diaryData.pulpitData.minPulpitDestroyTime;
        var maxDestroyTime = diaryComponent.diaryData.pulpitData.maxPulpitDestroyTime;

        var randomDestroyTime = Random.Range(minDestroyTime, maxDestroyTime);

        Invoke("Die", randomDestroyTime);
    }
}
