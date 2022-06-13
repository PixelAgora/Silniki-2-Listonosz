using System;
using UnityEngine;

namespace Code.InteractionSystem
{
    public class Interactor : MonoBehaviour
    {
        
        private IInteractive currentObject;
        private bool inputPressed;
        private bool inputReleased;

        

        private const KeyCode INTERACTION_KEY_CODE = KeyCode.E; // Set here your keyboard shortcut for interaction
        
        private void Update()
        {
            HandleInteractiveUpdate();
        }
        
        private void LateUpdate()
        {
            HandleInputUpdate();
        }

        

        private void OnTriggerEnter(Collider other)
        {
            
            IInteractive obj = other.GetComponent<IInteractive>();
            if (obj != null)
            {
                HandleObjectEnter(obj);
                

                
            }
        }
        
        private void OnTriggerExit(Collider other)
        {
            IInteractive obj = other.GetComponent<IInteractive>();
            if (obj != null)
            {
                HandleObjectExit(obj);
                
                
            }
        }

        private void HandleObjectEnter(IInteractive obj)
        {
            //Check if there's an interaction with currentObject and stop it
            if (currentObject != null && currentObject.IsInteracting && currentObject.InteractOnHold)
            {
                currentObject.Interact(this);
            }

            currentObject = obj;
        }

        private void HandleObjectExit(IInteractive obj)
        {
            if (obj == currentObject)
            {
                if (currentObject.IsInteracting && currentObject.InteractOnHold)
                {
                    currentObject.Interact(this);
                }
                currentObject = null;
            }
        }

        private void HandleInteractiveUpdate()
        {
            if (currentObject == null)
            {
                return;
            }

            if (currentObject.InteractOnHold)
            {
                if((!currentObject.IsInteracting || !inputReleased) &&
                   (currentObject.IsInteracting || !inputPressed))
                {
                    return; 
                }
                
                currentObject.Interact(this);
            }
            else if (inputPressed)
            {
                currentObject.Interact(this);
            }
        }

        private void HandleInputUpdate()
        {
            inputPressed = Input.GetKeyDown(INTERACTION_KEY_CODE);
            inputReleased = Input.GetKeyUp(INTERACTION_KEY_CODE);
        }
    }
}
