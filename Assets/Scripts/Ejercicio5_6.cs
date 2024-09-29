using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int nivelPokemon = 70;

    // Start is called before the first frame update
    void Start()
    {
        if (nivelPokemon / 10 == 0)
        {
            Debug.Log(nivelPokemon);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Cada 10 niveles, un Pokémon aprende un ataque diferente. Necesitamos saber cuándo llega a dichos niveles.
//Para ello, desarrolla un programa que lea un número entero por  el Inspector (nivel) y muestre si el número es múltiplo de 10.