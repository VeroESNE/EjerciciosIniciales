using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 2;
    int puntuacion2 = 4;
    int puntuacion3 = 6;
    int mediaPuntuaciones;
    // Start is called before the first frame update
    void Start()
    {
        mediaPuntuaciones = (puntuacion1 + puntuacion2 + puntuacion3) / 3;
        Debug.Log( "Puntuación 1: " + puntuacion1 + ", Puntuación 2: " + puntuacion2 + ", Puntuación 3: " + puntuacion3 + ", Media: " + mediaPuntuaciones);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
