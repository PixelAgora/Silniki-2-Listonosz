using Code.InteractionSystem;
using UnityEngine;

namespace Code.ExampleInteractive
{
    public class ChangeColorHold : MonoBehaviour, IInteractive
    {
        [SerializeField] private MeshRenderer meshRenderer;
        [SerializeField] private Color inactiveColor;
        [SerializeField] private Color interactionColor;
        
        public bool IsInteracting { get; private set; }
        public bool InteractOnHold => true;

        private void Start()
        {
            meshRenderer.material.color = inactiveColor;
        }
        
        public void Interact(Interactor interactor)
        {
            IsInteracting = !IsInteracting;

            meshRenderer.material.color = IsInteracting ? interactionColor : inactiveColor;
        }
    }
}