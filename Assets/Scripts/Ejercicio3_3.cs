using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero = 8;

    // Start is called before the first frame update
    void Start()
    {
        int doble = numero * 2;
        int triple = numero * 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Desarrolla un programa que lee un n�mero entero por el Inspector y almacena el doble y el triple de ese n�mero en otras dos variables.
//Despu�s, mostrar el contenido de estas  dos �ltimas variables por consola. 
