using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Code.InteractionSystem;
using UnityEngine.UI;

public class HouseExitDoor : MonoBehaviour, IInteractive
{
    public bool IsInteracting => true;

    public bool InteractOnHold => false;

   

    public void Interact(Interactor interactor)
    {
        PlayerData data = interactor.GetComponent<PlayerData>();
        if (data != null && data.HasBackpack)
        {
            //Dla zmiany poziomó zmień debug log na to co potrzebne do zmiany poziomu
            Debug.Log("Doors are open!");
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        PlayerData data = other.GetComponent<PlayerData>();
        if (data != null)
        {
            string text = data.HasBackpack ? "" : "You can't leave without backback";
            Code.UI.UIController.Instance.PromptDisplay.ShowText(text);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerData data = other.GetComponent<PlayerData>();
        if (data != null)
        {
            Code.UI.UIController.Instance.PromptDisplay.HideText();
        }
    }
}
