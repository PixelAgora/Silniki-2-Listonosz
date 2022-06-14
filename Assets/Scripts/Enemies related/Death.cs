/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour{

    public GameController GameController;
    public Vector3 startPosition;

    public void Die(){
        if(GameObject.Find("Player").transform.position.y <= 5){
            GameController.GameOver();
        }
    }

    public void Kill(){
        Debug.Log(" no i jest epicko ");
        GameController.GameOver();
    }

}

//player dies when he reaches certain height y= -5






// mając trapa, żeby trap mówił graczowi, że ma go zabić
// tag obstacle nie mówi dużo, trza żeby mówił, że zabija
// relacja ma być tylko pomiędzy trapem a graczem. Event system - trap > wejście > jeden obiekt decyduje co się dzieje
// pobrać z other (get component) > wykonać akcję na obiekcie
// interesuje nas tylko gracz
// trap powinien mieć metodę a gracz info czy wszedł
// zależności dwukierunkowe to ZUO
// poczytać o solid (abstrakcje a nie konkretne realizacje) (Pioprek się czepia)
// klasa pickup z pierwszego semestru
/*public Vector3 startPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Bomb")
        {
           Kill();
        }
    }
    public void Kill()
    {
        Debug.Log(" no i jest epicko ");
        transform.position = startPosition;
    }

    public void Death(){
        
    }
    */