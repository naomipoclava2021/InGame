using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gun : MonoBehaviour
{
    public static int cantidadDeDiparo = 0;
    public float rango = 100f;
    public Camera fpscmp;

    //Efectos

    public GameObject efectoImpacto;
    public GameObject efectoImpactoCaja;
    public ParticleSystem particulaDisparo;
    public ParticleSystem casquilloEffect;

    //sonido
    public AudioSource _audioSource;
    public AudioClip _sonidoDisparo;
    public AudioClip _sonidoHit;
    public AudioClip _sonidoCaja;

    public static float vidaJugador = 100f;
    public static float vidaJugadorBlood = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Disparar();
            cantidadDeDiparo++;
        }
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene(2);
        }
        
    }

    void Disparar()
    {
        RaycastHit hit;
        PlaySound(_sonidoDisparo);
        particulaDisparo.Play();
        casquilloEffect.Play();

        if (Physics.Raycast(fpscmp.transform.position, fpscmp.transform.forward, out hit, rango))
        {
            if(hit.transform.tag == "Enemigo")
            {
                hit.transform.gameObject.GetComponent<Enemigo>().vidaEnemigo -= 10;
                PlaySound(_sonidoHit);
                GameObject efecto = Instantiate(efectoImpacto, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(efecto, 3f);
                vidaJugador -= 3.3f;
                vidaJugadorBlood -= 10;

            }

            if (hit.transform.tag == "Cofre")
            {
                PlaySound(_sonidoCaja);
                GameObject efectoCaja = Instantiate(efectoImpactoCaja, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(efectoCaja, 3f);

            }
        }
    }

    void PlaySound(AudioClip clip)
    {
        _audioSource.clip = clip;
        _audioSource.Play();
    }
}
