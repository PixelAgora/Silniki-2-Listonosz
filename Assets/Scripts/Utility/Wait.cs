using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    [SerializeField] private string gameSceneName;

    void Awake()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(19);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        SceneManager.LoadScene("Starting room",LoadSceneMode.Single);
    }
}