using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int nivelpersonaje = 7;

    // Start is called before the first frame update
    void Start()
    {
        if (nivelpersonaje % 2 == 0)
        {
            Debug.Log("Es par.");
        }

        else
        {
            Debug.Log("Es impar.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Desarrolla un programa que lea el nivel de un personaje por el Inspector y calcule si es par o impar.
