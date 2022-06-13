namespace Code.InteractionSystem
{
    public interface IInteractive
    {
        bool IsInteracting { get; }
        bool InteractOnHold { get; }
        void Interact(Interactor interactor); //This should be used to either start or stop interaction
        //We're passing the Interactor so we can eventually use some parameters from it
    }
}