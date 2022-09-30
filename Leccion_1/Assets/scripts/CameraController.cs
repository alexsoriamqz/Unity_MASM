//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject tanquesin;
    // Start is called before the first frame update

    //Establecemos las coordenadas de la camara de donde se posiciona
    private Vector3 pos = new Vector3(0,10,-10);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Le indicamos al objeto tanquesin la posicion de la camara 
        transform.position = tanquesin.transform.position + pos;
    }
}
