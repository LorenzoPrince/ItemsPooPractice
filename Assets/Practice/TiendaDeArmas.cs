using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiendaDeArmas : MonoBehaviour
{
    public class Tienda //puede estar declarado afuera tambien
    {
        //encapsulacion
        // una forma de hacerlo
        private string nombre; // la variable privada que bno se puede acceder.
        public string Nombre // es el nombre que se usa para hacer al valor con get o asignar un valor con set.
        {
            get { return nombre; } // retorna el valor osea te lo muestra (da) cuando lo pidas 
            set { nombre = value; } // el asigna el valor que es por ende se puede cambiar
        }
        // otra forma mas abrebiada 
        public float Precio { get; set; }

    }
    private void Start()
    {
        // con new hacemos una nueva instania de la clase. crea una nueva con el new
        Tienda Espada = new Tienda { Nombre = "Espada de Hierro", Precio = 1.5f};
        Debug.Log($"{Espada.Nombre}: se vende por {Espada.Precio:C2}");

        Tienda Escudo = new Tienda { Nombre = "Escudo de madera", Precio = 0.5f };
        Debug.Log($"{Escudo.Nombre}: se vende por {Escudo.Precio:C2}");

        Tienda Pistola = new Tienda { Nombre = "Pistola", Precio = 9999f };
        Debug.Log($"{Pistola.Nombre}: se vende por {Pistola.Precio:C2}");
    }
    // esto sirve para tener mas seguridad.
}