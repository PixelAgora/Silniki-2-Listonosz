using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Code.Tools;
using TMPro;

namespace Code.UI
{
    
     public class UIController : SingletonKurde<UIController>
     {
        [SerializeField] private PromptDisplay promptDisplay;
        

         public PromptDisplay PromptDisplay => promptDisplay;
     }
    
}