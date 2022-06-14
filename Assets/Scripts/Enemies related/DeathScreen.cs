using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Dieplease
{
public class DeathScreen : MonoBehaviour
{
    public Button retryButton;
    public Button exitButton;
    public Text Deathinfo;

    public void Awake(){
        gameObject.SetActive(false);
    }
    public void Setup(){
        gameObject.SetActive(true);
        Deathinfo.text = "Złapano Cię morduniu";
    }
    
    public void RestartButton(){
        SceneManager.LoadScene("Menu");
    }

    public void ExitButton() {
        Application.Quit();
    }
      
}
}
