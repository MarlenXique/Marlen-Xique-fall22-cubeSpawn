using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript1 : MonoBehaviour
{

    public GameObject cube;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {

        Instantiate(cube, new Vector3(i * 5.0f, 0, 0), Quaternion.identity);
            
        }
    }

    void Update()
        {

     }
 }
