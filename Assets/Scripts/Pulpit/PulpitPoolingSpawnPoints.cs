using System.Linq;
using UnityEngine;

public class PulpitPoolingSpawnPoints : MonoBehaviour
{
    [SerializeField]
    private GameObject northPulpit;

    [SerializeField]
    private GameObject southPulpit;

    [SerializeField]
    private GameObject eastPulpit;

    [SerializeField]
    private GameObject westPulpit;

    public GameObject[] AvaliableDirections
    {
        get
        {
            var possibleDirections = new GameObject[] { northPulpit, southPulpit, eastPulpit, westPulpit };
            return possibleDirections.Where((e) => e != null).ToArray();
        }
    }
}
