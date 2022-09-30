//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    //Se inicializa el vector3 para el seguimiento de la camara al avion
    private Vector3 offset = new Vector3(50,5,0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Asignamos la camara sobre el avion
        transform.position = plane.transform.position + offset;
    }
}
