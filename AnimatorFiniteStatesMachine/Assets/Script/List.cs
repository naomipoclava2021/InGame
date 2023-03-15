using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public List<int> valor = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        valor.Add(2);
        valor.Add(39);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            valor.Add(30);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log(valor.Count);
        }

        if (Input.GetKeyDown(KeyCode.R))  //Remover
        {
            valor.RemoveAt(0);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            valor.Insert(2, 300);
        }

        if (Input.GetKeyDown(KeyCode.V)) //vaciar
        {
            valor.Clear();
        }

    }


}
