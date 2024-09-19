using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidad1 = 70.0f;
    [SerializeField] float velocidad2 = 120.0f;
    [SerializeField] float velocidad3 = 90.0f;
    [SerializeField] float velocidadMedia;
    // Start is called before the first frame update
    void Start()
    {
        velocidadMedia = ((velocidad1 + velocidad2 + velocidad3) / 3) * (1000/3600);
        Debug.Log("Media en m/s " + velocidadMedia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Se desea desarrollar un juego de carreras y se han de calcular las velocidades de varios  vehículos. 
//Para ello, desarrolla un programa que lea por el Inspector una velocidad  medida en Km/h y la convierta a m/s, almacenando este dato en una nueva variable. 
//Después, mostrar el contenido de esta variable por consola.
