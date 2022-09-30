//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Se indica que el objeto se movera hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
