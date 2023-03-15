using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestAudio : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            AudioManager.PausarSonido();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            AudioManager.Despausar();
        }
        
    }
}
