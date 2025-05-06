using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("Velocidad del jugador")]
    public CanvasManager cm;

    [Tooltip("Velocidad del jugador")]
    private Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Cubo>())
        {
            anim.Play("Saludo");
            //utilizamos el get de lavariable saludo dentro del cubo para saludar
            string saludo = ("hola: " + "" + collision.GetComponent<Cubo>().Nombre);
            Debug.Log("hola: " + "" + collision.GetComponent<Cubo>().Nombre);
            cm.IntroducirTexto(saludo);
            cm.AbrirCartel();
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        cm.CerrarCartel();
    }






}
