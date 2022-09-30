//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float Velocidad;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //definimos las varibales para la entradas de los movimientos que tendra el objeto tanquesin
        float avanza = Input.GetAxis("Vertical");
        float girar = Input.GetAxis("Horizontal");

        //Le indicamos que su movimiento sea frontal agregando la velocidad
        transform.Translate(Vector3.forward*Time.deltaTime*Velocidad*avanza);
        //Le indicamos que su movimiento sea rotatorio
        transform.Rotate(Vector3.up, Time.deltaTime * 70 *girar);
    }
}
