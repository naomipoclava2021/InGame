using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    // Start is called before the first frame update
    public bool activaPausa;
    public GameObject hud;
    public GameObject pausa;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AnalisaPausa();
    }

    void AnalisaPausa()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (activaPausa == true)
            {
                SalirDePausa();
            }
            else
            {
                Pausar();
            }
        }
    }

    void SalirDePausa()
    {
        pausa.SetActive(false);
        hud.SetActive(true);
        activaPausa = false;
        Time.timeScale = 1;

    }
    
    void Pausar()
    {
        pausa.SetActive(true);
        hud.SetActive(false);
        activaPausa = true;
        Time.timeScale = 0; 
    }
}
