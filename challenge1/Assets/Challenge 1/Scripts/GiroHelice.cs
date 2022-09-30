//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroHelice : MonoBehaviour
{
    //variable para definir la velocidad a la que gira la helice
    public float velocidadGiro = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //indicamos sobre que eje se movera la helice y se multiplica por la velocidad
        transform.Rotate(Vector3.forward * velocidadGiro);
    }
}
