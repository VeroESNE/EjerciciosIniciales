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
        Debug.Log( "La persona se llama " + nombre + apellido1 + apellido2 + " y tiene 20 a�os.");
    }
}
//Crea un m�todo llamado �ConstruirNombre� que reciba por par�metros de entrada los datos de una persona: nombre, apellido1, apellido2, edad.
//Estos datos han de ser combinados dentro del m�todo para que este devuelva a su salida un texto con toda la informaci�n de la persona. 
//Por ejemplo: �La persona se llama Pepe Rodr�guez Jim�nez y  tiene 20 a�os�.
//Ejecuta este m�todo con valores de ejemplo desde el Start() y muestra el resultado que devuelve por consola.