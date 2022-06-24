using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsVideoExitButton : MonoBehaviour
{
    [SerializeField] private Button closeButton;
    

    private void Start ()
    {
        closeButton.onClick.AddListener(GoBackToCredits);
    }
    private void GoBackToCredits()
    {
        SceneManager.LoadScene("Credits",LoadSceneMode.Single);
    }

}