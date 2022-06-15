using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MemeButton : MonoBehaviour
{
    [SerializeField] private Button memeButton;
    

    

    private void Start ()
    {
        memeButton.onClick.AddListener(PlayMeme);
    }
    private void PlayMeme()
    {
        SceneManager.LoadScene("MemeVideo",LoadSceneMode.Single);
    }

}