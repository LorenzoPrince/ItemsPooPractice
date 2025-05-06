using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Encapsulamiento
    [SerializeField] Sprite playerRed;
    [SerializeField] private int vida = 0;
    [SerializeField] private bool inmune = false;
    private SpriteRenderer sr; // para poner un render para cambiar color por ejemplo.
    public enum PlayerState {normal,fuego,estrella} // para ver el estado
    public PlayerState player_state = PlayerState.normal; //normal es que podra ver en que estado esta. y que inicie en normal
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (vida)
        {
            case 0:
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0);
                break;
            case 1: //recordar que va dos puntos no punto y coma
                this.transform.localScale = new Vector3(1f, 1f, 0);
                break; 
            case 2:
                this.transform.localScale = new Vector3(1.3f, 1.3f, 0);
                break;

        }
        if (inmune)
        {
            sr.color = Random.ColorHSV(); //hace que cambie de forma random el color del spriterender.
        }
    }
    public void cambio_de_Estado(PlayerState player_state)
    {
        switch (player_state)
        { 
            case PlayerState.fuego:
                sr.sprite = playerRed;
                Debug.Log("Tambien tira fuego");
            break;
            case PlayerState.estrella:
               inmune = true;
                Debug.Log("soy inmune a todo");
                break;
        }
    }
    public void Incremento_de_Vida()
    {
        if (vida <= 2)
        {
            vida++;
        }
    }


}
