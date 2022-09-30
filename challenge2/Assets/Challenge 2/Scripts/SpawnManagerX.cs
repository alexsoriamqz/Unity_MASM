//Elaborado por: Manuel Alejandro Soria Márquez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    //Se definen los limites de donde spawnean las pelotas
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    //el intervalo de cuando inicia el juego y cada cuando sale una pelota
    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Invoca el spawn de pelotas
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        //Se creo una variable para que las bolas salgan en un intervalo de 0 a 3
        int bola = Random.Range(0,3);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[bola], spawnPos, ballPrefabs[bola].transform.rotation);
    }

}
