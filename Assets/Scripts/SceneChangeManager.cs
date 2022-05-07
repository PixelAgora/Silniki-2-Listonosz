using System;
using System.Collections;
using Code.Enums;
using Code.LevelControl;
using Code.Tools;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Managers
{
    public class ScenesChangeManager : Singleton<ScenesChangeManager>
    {
        [SerializeField] private SwitchAnimations animations;
        [SerializeField] private string menuSceneName;
        [SerializeField] private string firstGameplaySceneName;
        
        private WaitForSeconds oneSecond;
        private void Start()
        {
            animations.EndTransition();
            oneSecond = new WaitForSeconds(1f);
        }
        
        public void ChangeScene(int buildIndex)
        {
            StartCoroutine(LoadScene(buildIndex));
        }

        public void ChangeScene(string sceneName)
        {
            StartCoroutine(LoadScene(sceneName));
        }

        public void NextScene()
        {
            int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
            ChangeScene(nextIndex);
        }

        private IEnumerator LoadScene(int buildIndex)
        {
            animations.StartTransition();
            yield return oneSecond;
            AsyncOperation sceneLoad = SceneManager.LoadSceneAsync(buildIndex);
            yield return sceneLoad;
            animations.EndTransition();
        }

        private IEnumerator LoadScene(string sceneName)
        {
            animations.StartTransition();
            yield return oneSecond;
            AsyncOperation sceneLoad = SceneManager.LoadSceneAsync(sceneName);
            yield return sceneLoad;
            animations.EndTransition();
        }


        public void LoadMenu()
        {
            GameManager.Instance.GameState = GameState.Menu;
            ChangeScene(menuSceneName);
        }

        public void LoadGameplay()
        {
            GameManager.Instance.GameState = GameState.Gameplay;
            ChangeScene(firstGameplaySceneName);
        }
    }
}