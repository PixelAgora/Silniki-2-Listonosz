using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DeathScreen : MonoBehaviour
{
    public Button retryButton;
    public Button exitButton;
    public Text Deathinfo;
    //public LayerMask Water;

    public void Awake(){
        gameObject.SetActive(false);
        //player = GameObject.Find("Player").transform;
        //enemy = GameObject.Find("Enemy").transform;
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

