using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class DoNotDestroy : MonoBehaviour
{
    public static DoNotDestroy instance;
 
    void Awake()
    {
        if (instance != null && SceneManager.GetActiveScene().name == "Starting room")
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
 