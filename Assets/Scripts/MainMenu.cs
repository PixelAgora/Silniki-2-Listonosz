using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private Button optionsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private string gameSceneName;
    

    

    private void Start ()
    {
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
        optionsButton.onClick.AddListener(Options);
        creditsButton.onClick.AddListener(Credits);
    }
    private void StartGame()
    {
        LoadNextLevel();
    }

    private void ExitGame ()
    {
        Application.Quit();
    }
        private void Options ()
    {
        SceneManager.LoadScene("Options",LoadSceneMode.Single);
    }
        private void Credits ()
    {
        SceneManager.LoadScene("Credits",LoadSceneMode.Single);
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene("Starting room",LoadSceneMode.Single);
    }

}
