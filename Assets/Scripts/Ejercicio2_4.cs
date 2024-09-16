using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 7;

    // Start is called before the first frame update
    void Start()
    {
        vidas += 77;
        vidas -= 3;
        vidas *= 4;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

