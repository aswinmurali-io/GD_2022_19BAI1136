using UnityEngine;

interface IDataComponent<T>
{
    void EnableWithData(T data);
}

public class DoofusDiaryDataComponent : MonoBehaviour, IDataComponent<DoofusDiaryData>
{
    public static DoofusDiaryData data { get; private set; }

    [SerializeField]
    private DoofusMovement doofusMovement;

    [SerializeField]
    private PulpitsSpawningGameSystem pulpitsSpawningGameSystem;

    public void EnableWithData(DoofusDiaryData data)
    {
        Debug.Log(data);

        DoofusDiaryDataComponent.data = data;

        pulpitsSpawningGameSystem.enabled = true;
        doofusMovement.enabled = true;
    }
}
