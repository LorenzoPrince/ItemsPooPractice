using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour //es plantilla el abstract para otras clases.
{
    protected string nombre;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        if (player != null)
        {
            player = GetComponent<Player>();
        }
        else
        {
            player = FindObjectOfType<Player>();
        }

    }
    //public virtual void Consumible() es otra forma la cual hace que el codigo tenga una logica 
    // Debug.Log($"ni nombre es+ {nombres}");esto estara en el hijo
    public abstract void Consumible(); // toda clase debe tener su metodo consumible.y no tiene cuerpo el abstract.

    public virtual void Usar() //ejemplo de virtual el que permite llamarlo en los hijos
    {
        Debug.Log(" Powerup usado de forma generica");
    }
}
