using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    int numero = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (numero < 100)
        {
            Debug.Log(numero);
            numero++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//7.1.Programa que muestre los números del 1 al 100 utilizando la estructura while 
