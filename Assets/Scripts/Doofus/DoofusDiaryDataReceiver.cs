using System;
using System.Collections;
using Newtonsoft.Json;

using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(DoofusDiaryDataComponent))]
public class DoofusDiaryDataReceiver: MonoBehaviour
{
    [SerializeField]
    private DoofusDiaryDataComponent doofusDiaryDataComponent;

    private string url = "https://s3.ap-south-1.amazonaws.com/superstars.assetbundles.testbuild/doofus_game/doofus_diary.json";

    private void Start() => StartCoroutine(GetDataFromServer());

    // DoofusDiaryData
    private IEnumerator GetDataFromServer()
    {
        Debug.Log("Getting Doofus diary data from server...,");

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
                    "Received doofus diary json {0} from {1}", jsonString, url
                );

                Debug.Log(debugString);

                var diaryData = JsonConvert.DeserializeObject<DoofusDiaryData>(jsonString);

                doofusDiaryDataComponent.EnableWithData(diaryData);
            }
        }

        yield return null;
    }
}
