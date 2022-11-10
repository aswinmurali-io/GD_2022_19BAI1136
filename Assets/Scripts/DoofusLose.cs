using UnityEngine;
using UnityEngine.SceneManagement;

public class DoofusLose : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.transform.position.y < -3)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
