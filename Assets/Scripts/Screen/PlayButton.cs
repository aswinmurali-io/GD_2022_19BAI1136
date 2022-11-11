using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    [SerializeField]
    private Button button;

    void Start() => button.onClick.AddListener(MoveToGame);

    void MoveToGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}
