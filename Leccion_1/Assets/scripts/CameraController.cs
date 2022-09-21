using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject tanquesin;
    // Start is called before the first frame update

    private Vector3 pos = new Vector3(0,10,-10);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = tanquesin.transform.position + pos;
    }
}
