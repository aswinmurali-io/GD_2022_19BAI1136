using UnityEngine;
using Zenject;

public class PulpitsSpawning : MonoBehaviour
{
    private bool updateLock = false;

    private void Spawn()
    {
        var pulpitGameObjects = GameObject.FindGameObjectsWithTag("Pulpits");

        foreach (var pulpitObject in pulpitGameObjects)
        {
            if (pulpitObject.activeInHierarchy)
            {
                var spawnPoints = pulpitObject.GetComponent<PulpitPoolingSpawnPoints>().AvaliableDirections;
                var random = new System.Random();
                var pickedPointIndex = random.Next(spawnPoints.Length);

                spawnPoints[pickedPointIndex].SetActive(true);
                return;
            }
        }
    }

    private void Update()
    {
        if (!updateLock)
        {
            updateLock = true;
            var spawnTime = DoofusDiaryDataComponent.data.pulpitData.spawnTime;
            Debug.Log(spawnTime);
            InvokeRepeating("Spawn", (float)spawnTime, (float)spawnTime);
        }
    }
}
