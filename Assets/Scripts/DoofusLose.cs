using UnityEngine;

public class DoofusLose : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y < -3)
        {
            Destroy(gameObject);
        }
    }
}
