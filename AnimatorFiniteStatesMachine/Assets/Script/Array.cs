using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public GameObject[] vidaJugaores = new GameObject[2];
    public string[] nombre = new string[2];
    public ParticleSystem[] particulas = new ParticleSystem[5];
    public AudioClip[] sonido = new AudioClip[4];
    public int[,] numeros= new int[3,2]; //Definir una matrix


    // Start is called before the first frame update
    void Start()
    {
        recorrerArrayFor();
        

        vidaJugaores[0].SetActive(false); // desactivar un gameoObject

    }

    void recorrerArrayFor()
    {
        for (int i = 0; i < vidaJugaores.Length; i++)
        {
            Debug.Log(vidaJugaores[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
