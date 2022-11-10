using UnityEngine;
using UnityEngine.SceneManagement;

public class DoofusLoseOutsideLevel : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.transform.position.y < -10)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
