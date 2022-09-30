//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    //Cuando el objeto collisiona se destruye
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
