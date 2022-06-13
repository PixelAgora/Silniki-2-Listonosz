using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    

    private ICollectible currentCollectible;

    private void OnTriggerEnter(Collider other)
    {
        ICollectible collectible = other.GetComponent<ICollectible>();

        if (collectible != null)
        {
            currentCollectible = collectible;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ICollectible collectible = other.GetComponent<ICollectible>();

        if (collectible != null && currentCollectible == collectible)
        {
            currentCollectible = null;
            
        }
    }

    private void Update()
    {
        if (currentCollectible != null && Input.GetKeyDown(KeyCode.E))
        {
            
            currentCollectible.Collect();
            currentCollectible = null;
            
        }
    }
}

