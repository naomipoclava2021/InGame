using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    public Text disparo;
    public Text muerte;
    public Enemigo ene;

    public Image imagenVerde;
    public Image imagenBloodHud;

    public float vidaActual;
    public float vidaActualBlood;
    public float vidaMaximaJugador=100f;
    public float vidaMaximaJugadorBood = 255f;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        disparo.text = "disparos " + Gun.cantidadDeDiparo;
        muerte.text = "Muerte " + Enemigo.muerteEnemigo;
        vidaActual = Gun.vidaJugador;
        vidaActualBlood = Gun.vidaJugadorBlood;
        imagenVerde.fillAmount = vidaActual /100f;
        imagenBloodHud.color = new Color(255, 255, 255, -vidaActualBlood / 255f);
        
    }
}
