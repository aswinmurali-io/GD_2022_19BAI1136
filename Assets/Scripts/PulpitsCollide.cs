using UnityEngine;

public class PulpitsCollide : MonoBehaviour
{
    [SerializeField]
    private DoofusScore doofusScore;

    private void OnTriggerEnter(Collider col)
    {
        doofusScore.pulpitsVisitedIds.Add(gameObject.GetInstanceID());
        Debug.Log(true);
    }
}
