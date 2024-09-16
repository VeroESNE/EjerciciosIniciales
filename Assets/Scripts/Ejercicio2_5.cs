using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 5;
    int vidasPlayer2 = 7;
    int vidasPlayer3 = 15;
    int vidasPlayer4 = 10;

    // Start is called before the first frame update
    void Start()
    {
        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = vidasPlayer2;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
