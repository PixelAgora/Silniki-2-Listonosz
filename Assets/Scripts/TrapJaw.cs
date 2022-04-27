using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapJaw : MonoBehaviour
{
     public void OnTriggerEnter()
    {
       if (other.GameObject.tag == "Player") 
        {
           Debug.Log(" no i jest ");
        }
        
    }
    public void Trap()
    {

    }

    public void Release()
    {

    }
}
