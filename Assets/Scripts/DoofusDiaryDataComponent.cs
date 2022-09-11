using System;
using UnityEngine;

public class DoofusDiaryDataComponent : MonoBehaviour
{
    public DoofusDiaryData diaryData;

    public bool DiaryFound(string dependentComponentName)
    {
        if (diaryData == null)
        {
            Debug.Log(String.Format(@"Diary yet to be found! {0}
            component is waiting for data from server...", dependentComponentName));
            return false;
        }
        return true;
    }
}
