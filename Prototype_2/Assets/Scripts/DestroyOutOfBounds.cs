//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //Se definen las cordenadas para saber donde se destruiran
    private float topBound = 25;
    private float lowerBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Destruye el elemento despues de cierta distancia recorrida
        //o si pasa al jugador
        if(transform.position.z > topBound){
            //Si esta fuera del rango de topBound se destruye el objeto
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound){
            //Si el elemento pasa al jugador, el juego se termina ademas de que el objeto se destruye.
            Debug.Log("GAME OVER!");
            Destroy(gameObject);
        }
    }
}
