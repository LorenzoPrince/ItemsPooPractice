using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    private Animator anim;

    [Tooltip("Texto que aparece en el cartel")]
    public TMP_Text text; // Referencia al componente de texto en el UI

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void AbrirCartel()
    {
        anim.Play("Poup");
    }
    public void CerrarCartel()
    {
        anim.Play("PopOut");
    }
    public void IntroducirTexto(string texto)
    {
        text.text = texto;
    }

}
