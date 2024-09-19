using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    string nombre = "Veronica";
    string apellido1 = "Arce";
    string apellido2 = "Saavedra";
    // Start is called before the first frame update
    void Start()
    {
        ConstruirNombre(); 
    }

    void ConstruirNombre()
    {
        Debug.Log( "La persona se llama " + nombre + apellido1 + apellido2 + " y tiene 20 años.");
    }
}
//Crea un método llamado “ConstruirNombre” que reciba por parámetros de entrada los datos de una persona: nombre, apellido1, apellido2, edad.
//Estos datos han de ser combinados dentro del método para que este devuelva a su salida un texto con toda la información de la persona. 
//Por ejemplo: “La persona se llama Pepe Rodríguez Jiménez y  tiene 20 años”.
//Ejecuta este método con valores de ejemplo desde el Start() y muestra el resultado que devuelve por consola.