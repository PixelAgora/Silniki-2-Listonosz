using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Tools
{
    public class SingletonKurde<T> : MonoBehaviour where T : MonoBehaviour
    {
        [SerializeField] private bool dontDestroyOnLoad;
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance != null) return instance;
                instance = (T)FindObjectOfType(typeof(T));
                if (instance == null)
                {
                    instance = new GameObject(typeof(T).ToString()).AddComponent<T>();
                }
                return instance;
            }
            set => instance = value;
        }

        protected virtual void Awake()
        {
            Instance = this as T;
            if (dontDestroyOnLoad)
            {
                if (transform.parent != null)
                {
                    transform.SetParent(null);
                }
                DontDestroyOnLoad(gameObject);
            }
        }

        protected void OnDestroy()
        {
            Instance = null;
        }
    }
}