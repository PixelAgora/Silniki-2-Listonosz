using UnityEngine;
using TMPro;

namespace Code.UI
{
    public class PromptDisplay : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI promptText;

        public void ShowText(string text)
        {
            promptText.text = text;
        }

        public void HideText()
        {
            promptText.text = string.Empty;
        }
    }
}