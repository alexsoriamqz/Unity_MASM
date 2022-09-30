//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    // Start is called before the first frame update
//Se declara una variable donde se almacena la velocidad de la comida
public float speed = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se le indica el movimiendo frontal de la comida, ademas de la velocidad que tendra
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
}
