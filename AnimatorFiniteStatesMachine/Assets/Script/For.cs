using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour
{
    public GameObject prefab;
    public GameObject[] cubo;
    
    // Start is called before the first frame update
    void Start()
    {
        cubo = new GameObject[10];

        for (int i = 0; i <cubo.Length; i++)
        {
            GameObject distaciaDeCubo = Instantiate(prefab, new Vector3(i, 0, 0), transform.rotation);
            cubo[i] = distaciaDeCubo;
        }


        for (int i =0; i<10; i++)
        {
            Debug.Log("creciente "+i);
        }

        for (int i=90; i > 0; i--)
        {
            Debug.Log("Decreciente" + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
