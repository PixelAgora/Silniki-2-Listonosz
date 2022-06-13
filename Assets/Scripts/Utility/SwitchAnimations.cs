using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Code.LevelControl
{
    public class SwitchAnimations : MonoBehaviour
    {
        [SerializeField] private Animator[] animators;
        
        private readonly int START_HASH = Animator.StringToHash("Start");
        private readonly int END_HASH = Animator.StringToHash("End");

        private int transitionIndex = 0;

        private bool hasStarted;

        
        public void StartTransition()
        {
            if (hasStarted)
            {
                EndTransition();
            }
            transitionIndex = Random.Range(0, animators.Length);
            animators[transitionIndex].SetTrigger(START_HASH);
            hasStarted = true;
        }

        public void EndTransition()
        {
            hasStarted = false;
            animators[transitionIndex].SetTrigger(END_HASH);
        }
    }
}