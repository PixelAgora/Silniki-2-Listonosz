using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBomb : MonoBehaviour
{
     public void OnTriggerEnter()
    {
        if (tag == "Player") 
        {
           Debug.Log(" no i jest ");
        }
    }
    
      public void Kill()
    {
        
    }
}
