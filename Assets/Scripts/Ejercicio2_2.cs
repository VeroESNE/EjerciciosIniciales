using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 10;
    float exp = 7.5f;
    char carac = 'V';
    //float resultadoSuma;
    //float resultadoResta;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vidas + exp);
        float resultadoSuma = vidas + exp;
        float resultadoResta = exp - vidas;
        //resultadoSuma = vidas + exp;
        //resultadoResta = exp - vidas;
        Debug.Log(resultadoSuma + " " + resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
