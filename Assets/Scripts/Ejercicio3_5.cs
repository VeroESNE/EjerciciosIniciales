using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radioCircunferencia = 5;
    [SerializeField] float areaCircunferencia;
    [SerializeField] float longitudCircunferencia;
    // Start is called before the first frame update
    void Start()
    {
        areaCircunferencia = 3.1416f * (radioCircunferencia * radioCircunferencia);
        longitudCircunferencia = 2 * 3.1416f * radioCircunferencia;
        Debug.Log(longitudCircunferencia + areaCircunferencia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Se desea desarrollar un programa para calcular el �rea de visi�n de un enemigo. Dicha �rea tiene forma de circunferencia. 
//Para ello, desarrolla un programa que lea por el  Inspector el radio de una circunferencia y calcule la longitud y el �rea de la  circunferencia, 
//almacenando estos dos datos en dos variables. Despu�s, mostrar el  contenido de estas dos variables por consola.
//Longitud de la circunferencia =  2*PI*Radio, �rea de la circunferencia = PI*Radio^2