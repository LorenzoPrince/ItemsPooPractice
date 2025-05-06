using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    //tooltip sirve para ver mensajes. 
    [Tooltip("Velocidad del jugador")]
    public float velocidad;
    [Tooltip("nombre del jugador")]
    private string nombre;
    public string Nombre { get => nombre; set => nombre = value; }


    private void FixedUpdate()
    {
        Movimiento();
    }
    void Movimiento() //privado por defecto
    {
        float speed_x = Input.GetAxis("Horizontal"); //agarra la entrada del usuario en horizontal
        transform.position += new Vector3(speed_x, 0, 0) * Time.deltaTime * velocidad; //lo mueve en direccion horizontal
    }
}
