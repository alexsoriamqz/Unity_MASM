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
        float avanza = Input.GetAxis("Vertical");
        float girar = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward*Time.deltaTime*Velocidad*avanza);
        transform.Rotate(Vector3.up, Time.deltaTime * 70 *girar);
    }
}
