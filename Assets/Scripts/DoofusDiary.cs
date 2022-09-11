using System;
using System.Collections;
using Newtonsoft.Json;

using UnityEngine;
using UnityEngine.Networking;

public class DoofusDiary : MonoBehaviour
{

    private string url = "https://s3.ap-south-1.amazonaws.com/superstars.assetbundles.testbuild/doofus_game/doofus_diary.json";

    private DoofusDiaryDataComponent diaryComponent;

    void Start()
    {
        Debug.Log("Getting Doofus diary data from server...");
        StartCoroutine(GetDataFromServer());
        diaryComponent = GetComponent<DoofusDiaryDataComponent>();
    }

    // DoofusDiaryData
    IEnumerator GetDataFromServer()
    {
        using (var request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log(request.error);
            }
            else
            {
                var jsonString = request.downloadHandler.text;

                var debugString = String.Format(
                    "Received json {0} from {1}", jsonString, url
                );

                Debug.Log(debugString);

                var diaryData = JsonConvert.DeserializeObject<DoofusDiaryData>(jsonString);

                diaryComponent.diaryData = diaryData;

                Debug.Log(diaryData);
            }
        }
    }
}
