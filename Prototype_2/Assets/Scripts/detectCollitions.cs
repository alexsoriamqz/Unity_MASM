//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollitions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Se crea una funcion para detectar la collision entre la comida y el animal(entre ambos objetos)
    private void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);
        Destroy(other.gameObject);    
    }
}
