using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code.InteractionSystem
{
    public class CollectibleBackpack : MonoBehaviour, IInteractive
    {
        public bool IsInteracting { get; }

        public bool InteractOnHold => false;

        public void Interact(Interactor interactor)
        {
            gameObject.SetActive(false);
            interactor.GetComponent<PlayerData>().HasBackpack = true;
        }
    }
}