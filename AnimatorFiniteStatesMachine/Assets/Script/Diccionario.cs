using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diccionario : MonoBehaviour
{
    Dictionary<string, bool> esLatino = new Dictionary<string, bool>();


    // Start is called before the first frame update
    void Start()
    {
        esLatino.Add("Alemania", false);
        esLatino.Add("Brazil", true);
        esLatino.Add("Argentina", true);

        Debug.Log(esLatino.Remove("Argentina"));
        Debug.Log(esLatino["Brazil"]);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
