using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int numero1 = 10; //dividendo
    [SerializeField] int numero2 = 5; //divisor
    [SerializeField] int resultado;
    // Start is called before the first frame update
    void Start()
    {
        if (numero2 != 0)
        {
            resultado = numero1 / numero2;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}

