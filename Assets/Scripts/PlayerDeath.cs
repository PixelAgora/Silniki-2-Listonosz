using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour

{
private Vector3 startPosition;

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
           Kill();
        }
    }
    private void Kill()
    {
        transform.position = startPosition;
    }
}
