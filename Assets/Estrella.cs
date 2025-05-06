using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrella : PowerUp
{
    // Start is called before the first frame update
    // herencia y abstracción
    public override void Consumible() // reescribe el metodo de la clase padre. 
    {
        //player referia a la del padre de ahi voy a cambio que recibe de parametro el estado de mario y hace lo que pasa.
        player.cambio_de_Estado(Player.PlayerState.estrella);

        // si tengo otro codigo con virtual puedo usar la logica anterior
        //base.Consumible 
        // y puedo agregar mas base anterior.
    }
        //ejemplo:
    public override void Usar()
    {
        base.Usar();  // Solo ejecuta la lógica de la clase base.
    }
}

