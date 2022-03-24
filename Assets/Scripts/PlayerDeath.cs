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
// mając trapa, żeby trap mówił graczowi, że ma go zabić
// tag obstacle nie mówi dużo, trza żeby mówił, że zabija
// relacja ma być tylko pomiędzy trapem a graczem. Event system - trap > wejście > jeden obiekt decyduje co się dzieje
// pobrać z other (get component) > wykonać akcję na obiekcie
// interesuje nas tylko gracz
// trap powinien mieć metodę a gracz info czy wszedł
// zależności dwukierunkowe to ZUO
// poczytać o solid (abstrakcje a nie konkretne realizacje) (Pioprek się czepia)
// klasa pickup z pierwszego semestru