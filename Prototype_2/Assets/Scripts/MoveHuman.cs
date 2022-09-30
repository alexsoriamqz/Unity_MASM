//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHuman : MonoBehaviour
{
    //Se declaran las variables para la velocidad del humano y el max que se podra mover a los laterales
    public float vel = 20.0F;
    public float max = 15;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Una condicion donde se le indica que si pasa el valor max en el eje x ya no puede pasar mas
        if(transform.position.x > max){
            transform.position = new Vector3(max, transform.position.y, transform.position.z);
        }
        //Una condicion donde se le indica que si pasa el valor max en negativo en el eje x ya no puede pasar mas
        if(transform.position.x < -max){
            transform.position = new Vector3(-max, transform.position.y, transform.position.z);
        }
        //Se define una variable donde le inficamos la entrada que ser de tipo horizaontal
        float flechas = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*vel*flechas);
        
        //Un condicional el cual al promir la tecla espacio, dispara el proyectil.
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
