using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseRotation : MonoBehaviour
{


    void Update()
    {
        Vector3 mouseWorldPosition = Input.mousePosition;
        float angle = AngleBetweenPoints(transform.position, mouseWorldPosition);
        transform.rotation =  Quaternion.Euler(new Vector3(0f,angle,0f));
    }
    private float AngleBetweenPoints(Vector2 a, Vector2 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
