using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numero1 = 10;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 > 0 && numero1 < 9)
        {
            Debug.Log(numero1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Programa que lea un número entero por el Inspector y compruebe si es un número comprendido entre '0' y '9'.
