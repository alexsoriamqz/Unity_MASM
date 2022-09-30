//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //Se definen variables para establecer los parametros
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Se indica que la entrada de movimiento sera vertical
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate || se cambio back por forward para que valla hacia adelante
        // y ademas se agrego que se multiplique por Time.deltaTime
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys || lo multiplicamos por la variable donde le indicamos que tendra movimiento vertical
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
