using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timetodie : MonoBehaviour
{
    public GameObject objectToAccess;
    public DeathScreen scriptToAccess;

    public void Awake(){
        scriptToAccess = objectToAccess.GetComponent<DeathScreen>();
    }
    public void OnTriggerEnter(Collider other){
        if (other.CompareTag("Enemy")){
            scriptToAccess.Setup();
        }
        if (other.CompareTag("Trap")){
            scriptToAccess.Setup();
        }
    }

}
