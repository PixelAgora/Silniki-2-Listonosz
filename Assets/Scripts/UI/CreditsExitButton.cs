using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsExitButton : MonoBehaviour
{
    [SerializeField] private Button closeButton;
    

    private void Start ()
    {
        closeButton.onClick.AddListener(GoBackToMenu);
    }
    private void GoBackToMenu()
    {
        SceneManager.LoadScene("Menu",LoadSceneMode.Single);
    }

}
