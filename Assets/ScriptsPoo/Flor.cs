using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flor : PowerUp
{
    // Start is called before the first frame update
    public override void Consumible()
    {
        player.cambio_de_Estado(Player.PlayerState.fuego);
    }
    // por ejemplo en esta clase no llamamos al metodo usar.
}
