using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float vidaEnemigo = 100;
    public GameObject efectoExplosion;

    public AudioSource _audioSource;
    public AudioClip explosionCajas;
    public static int muerteEnemigo = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaEnemigo <= 0)
        {
            GameObject explosion = Instantiate(efectoExplosion, transform.position, transform.rotation);
            Destroy(explosion, 4f);
            PlaySound(explosionCajas);
            Destroy(gameObject);
            muerteEnemigo++;
        }
    }

    void PlaySound(AudioClip clip)
    {
        _audioSource.clip = clip;
        _audioSource.Play();
    }
}
