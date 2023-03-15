using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame updat
    public static AudioManager instancia;
    AudioSource _audioSorce;
    private void Awake()
    {
        if(AudioManager.instancia == null)
        {
            AudioManager.instancia = this;
            DontDestroyOnLoad(gameObject);
            _audioSorce=GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    public static void PausarSonido()
    {
        instancia._audioSorce.Pause();
    }

    public static void Despausar()
    {
        instancia._audioSorce.UnPause();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
