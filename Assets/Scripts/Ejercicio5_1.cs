using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] int vida1 = 5;
    [SerializeField] int vida2 = 7;
    // Start is called before the first frame update
    void Start()
    {
        if (vida1 == vida2)
        {
            Debug.Log("La batalla est� re�ida.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
