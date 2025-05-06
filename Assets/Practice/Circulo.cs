using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo : MonoBehaviour
{

    [Tooltip("Referencia del Script: CanvasManager")] // el tooltip se ve en la consola
    public CanvasManager cm;

    [Tooltip("Referencia de la animacion del panel")]
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Cubo>().Nombre == "Cubito") // hacemos el get pq revisamos
        {
            collision.GetComponent<Cubo>().Nombre = "Circulo"; // estamos haciendo el set pq accinamos nuevo valor
            string saludo = "No me gusta tu nombre, ahora te llamas" + " " + collision.GetComponent<Cubo>().Nombre;
            cm.IntroducirTexto(saludo);
            anim.Play("SaludoC");
            cm.AbrirCartel();

        }
        else
        {
            string saludo = "Me gusta tu nombre";
            cm.IntroducirTexto(saludo);
            anim.Play("SaludoC_bueno ");
            cm.AbrirCartel();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        cm.CerrarCartel();
    }
}
