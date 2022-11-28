using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinetrial : MonoBehaviour
{
    public GameObject Cube;
    public GameObject[] SpawnPoints;


    // Start is called before the first frame update
    void Start()
    {
        SpawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoints");

        //Invoke Method
        
        Invoke("Cube", 5);
        Invoke("Collectable", 6);
        
        //StartCoroutine(GenerateAll());
        //StartCoroutine(GenerateAllAgain());
    }

    void SpawnCube()
    {
        for(int i = 0; i < SpawnPoints.Length; i++)
        {
            Instantiate(Cube, SpawnPoints[i].transform);
        }
    }}