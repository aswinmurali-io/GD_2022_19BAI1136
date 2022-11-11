using UnityEngine;

public class DoofusOnCollide : MonoBehaviour
{
    [SerializeField]
    private DoofusScore doofusScore;

    private int previousPulpitId = -1;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Pulpits" && previousPulpitId != hit.gameObject.GetInstanceID())
        {
            previousPulpitId = hit.gameObject.GetInstanceID();
            doofusScore.score++;
        }
    }
}
