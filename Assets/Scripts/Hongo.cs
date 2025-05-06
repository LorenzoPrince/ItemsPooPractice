using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hongo : PowerUp
{
    // Start is called before the first frame update
    public override void Consumible()
    {

        player.Incremento_de_Vida();
    }

    public override void Usar()
    {
        base.Usar();  // Solo ejecuta la lógica de la clase base.
        Debug.Log("anda el hongo"); //sobre escribe el metodo base. le agrega esto
        // sobrescribir o agregar mas logica a un metodo padre es Polimorfismo.
        // Usar override tambien es ejemplo de Polimorfismo
    }
}
