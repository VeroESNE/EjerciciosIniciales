using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    int numero = 100;
    // Start is called before the first frame update
    void Start()
    {
        while (numero > 0)
        {
            Debug.Log(numero);
            numero--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Programa que muestre los n�meros del 100 al 1 utilizando la estructura while
