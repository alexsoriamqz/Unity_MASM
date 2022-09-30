//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Se crea arreglo de los Prefabs de los animales disponibles
    public GameObject[] animalPrefabs;
    //Se declaran los metodolos con los parametros ya establecidos desde un principio
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        //Se invoca el metodo SpawnRandomAnimal al inicio y se le asigna un intervalo
        //de cada cuando se llama el metodo
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Metodo el cual spawnea los animales de manera aleatoria
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);

        //Instaciamos el gameObject del animal con sus parametros definidos
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
