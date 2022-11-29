using UnityEngine;
using Zenject;

public class DoofusOnCollide : MonoBehaviour
{
    [Inject]
    private IDoofusScore doofusScore;

    private int previousPulpitId = -1;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Pulpits" && previousPulpitId != hit.gameObject.GetInstanceID())
        {
            previousPulpitId = hit.gameObject.GetInstanceID();
            doofusScore.IncrementScore();
        }
    }
}
