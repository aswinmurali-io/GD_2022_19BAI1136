using UnityEngine;

public class PulpitsCollide : MonoBehaviour
{
    public GameObject doofus;

    void OnTriggerEnter(Collider col)
    {
        doofus.GetComponent<DoofusScore>().pulpitsVisitedIds.Add(gameObject.GetInstanceID());
        Debug.Log(true);
    }
}
