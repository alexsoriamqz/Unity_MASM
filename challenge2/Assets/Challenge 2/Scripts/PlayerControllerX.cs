//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //Se definen los parametros de tiempo de espera
    private float delayEspera = 1;
    private float DelayPerro = 0; 

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        //Se agrega en la condicion la entrada para invocar a los perros con space y para que no podamos invocar perros juntos.
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > DelayPerro)
        {
            //El tiempo entre cada perro
            DelayPerro = Time.time + delayEspera; 
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
