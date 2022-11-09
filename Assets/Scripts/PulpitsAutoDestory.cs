using TMPro;
using UnityEngine;

public class PulpitsAutoDestory : MonoBehaviour
{
    public GameObject gameSystem;

    public TextMeshPro timerText;

    private DoofusDiaryDataComponent diaryComponent;

    public GameObject doofusGameObject;

    private bool messageLock = false;

    void Awake()
    {
        if (gameObject.name != "Pulpit")
            enabled = true;
    }

    void Start() => diaryComponent = gameSystem.GetComponent<DoofusDiaryDataComponent>();

    void Die()
    {
        Destroy(gameObject);
        enabled = false;

        doofusGameObject.GetComponent<DoofusScore>().score += 1;
    }

    void Update()
    {
        if (!diaryComponent.DiaryFound("PulpitsAutoDestory")) return;

        var minDestroyTime = diaryComponent.diaryData.pulpitData.minPulpitDestroyTime;
        var maxDestroyTime = diaryComponent.diaryData.pulpitData.maxPulpitDestroyTime;

        var randomDestroyTime = Random.Range((float)minDestroyTime, (float)maxDestroyTime);

        if (!messageLock)
        {
            Debug.Log(System.String.Format("Pulpits ({0}) has destroy time set to {1} seconds", this.gameObject.GetInstanceID(), randomDestroyTime));
            Invoke("Die", randomDestroyTime);
            messageLock = true;
        }
    }
}
