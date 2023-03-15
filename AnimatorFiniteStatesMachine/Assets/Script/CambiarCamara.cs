using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarCamara: MonoBehaviour
{
   
    public GameObject camara1;
    public GameObject camara2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TransicionDeCamara();
        }
        
    }


    void TransicionDeCamara()
    {
        if (camara1.activeInHierarchy)
        {
            camara1.SetActive(false);
            camara2.SetActive(true);
        }
        else
        {
            camara1.SetActive(true);
            camara2.SetActive(false);
        }
    }
}
