using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 7;
    float exp = 7.5f;
    float resultadoMultiplicacion;
    float resultadoDivision;
    float resultadoResto;
    float resultadoDobleVidas;
    float resultadoTripleExp;


    // Start is called before the first frame update
    void Start()
    {
        resultadoMultiplicacion = vidas * exp;
        resultadoDivision = vidas / exp;
        resultadoResto = vidas % exp;
        resultadoDobleVidas = vidas *= 2;
        resultadoTripleExp = exp *= 3;

        //float resultadoMultiplicacion = vidas * exp;
        //float resultadoDivision = vidas / exp;
        //float resultadoResto = vidas % exp;
        //float resultadoDobleVidas = vidas *= 2;
        //float resultadoTripleExp = exp *= 3;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


