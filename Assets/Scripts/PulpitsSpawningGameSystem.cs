using UnityEngine;

public class PulpitsSpawningGameSystem : MonoBehaviour
{
    public GameObject pulpit;

    public DoofusDiaryDataComponent diaryComponent;

    private bool updateLock = false;

    void Spawn()
    {
        var pulpitGameObjects = GameObject.FindGameObjectsWithTag("Pulpits");

        if (pulpitGameObjects.Length == 1)
        {
            var lastPulpitObject = pulpitGameObjects[pulpitGameObjects.Length - 1];

            var newPulpit = Instantiate(
                pulpit, lastPulpitObject.transform.position, Quaternion.identity
            );
            newPulpit.SetActive(true);

            var spawnPoints = lastPulpitObject.GetComponent<PulpitsSpawnPoints>().newsPoints;

            var random = new System.Random();
            var pickedPointIndex = random.Next(spawnPoints.Length);

            pulpit.transform.position = spawnPoints[pickedPointIndex].transform.position;
        }
    }

    void Update()
    {
        if (!diaryComponent.DiaryFound("PulpitsSpawningGameSystem")) return;

        if (!updateLock)
        {
            updateLock = true;
            var spawnTime = diaryComponent.diaryData.pulpitData.pulpitSpawnTime;
            Debug.Log(spawnTime);
            InvokeRepeating("Spawn", 0, (float)spawnTime);
        }
    }
}
