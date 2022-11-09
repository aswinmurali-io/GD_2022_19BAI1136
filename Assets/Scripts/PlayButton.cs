using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        var play = yourButton.GetComponent<Button>();
        play.onClick.AddListener(MoveToGame);
    }

    void MoveToGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}
