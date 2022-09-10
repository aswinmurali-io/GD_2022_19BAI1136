using System;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Networking;

[Serializable]
class DoofusDiaryData { }


public class DoofusDiary : MonoBehaviour
{

    private string url = "https://s3.ap-south-1.amazonaws.com/superstars.assetbundles.testbuild/doofus_game/doofus_diary.json";

    void Start()
    {
        StartCoroutine(GetDiaryData());
    }

    IEnumerator<DoofusDiaryData> GetDiaryData()
    {
        using (var request = UnityWebRequest.Get("http://www.my-server.com"))
        {
            request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log(request.error);
            }
            else
            {
                // Show results as text
                var jsonString = request.downloadHandler.text;

                yield return JsonUtility.FromJson<DoofusDiaryData>(jsonString);
            }
        }
    }
}
