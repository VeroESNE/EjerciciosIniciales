using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float PV = 120.0f;
    float Veneno = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //PV = PV - PV * ((PV * 3) / 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//En un juego de combate por turnos, un personaje comienza con un total de 120 puntos de vida. 
//Es atacado y debido al efecto del veneno, se le va a ir restando vida cada turno. 
//Primero el 3% del total inicial, después el 6%  del total inicial, después el 9%  del total inicial, es decir, se va acumulando 3% más cada vez. 
//Haz un programa que muestre paso por paso la vida que le va quedando al personaje hasta el quinto turno. 
