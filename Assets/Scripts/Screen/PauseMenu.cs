using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private Button continueButton;

    [SerializeField]
    private Button exitButton;

    [SerializeField]
    private GameObject pauseMenuCanvas;

    // State
    private bool paused = false;

    private void Start()
    {
        continueButton.onClick.AddListener(OnContinue);
        exitButton.onClick.AddListener(OnExit);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !paused)
            OnPaused();

        else if (Input.GetKeyUp(KeyCode.Escape) && paused)
            OnContinue();
    }

    private void OnPaused()
    {
        if (!paused)
            paused = true;

        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    private void OnContinue()
    {
        if (paused)
            paused = false;

        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
    }

    private void OnExit() => Application.Quit();
}
