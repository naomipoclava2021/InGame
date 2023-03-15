using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackPila : MonoBehaviour
{
    public Stack tienda = new Stack();
    // Start is called before the first frame update
    void Start()
    {
        tienda.Push(true);
        tienda.Push(gameObject.name);
        tienda.Push(44);
        tienda.Push("Naomi");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log( tienda.Pop());
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log(tienda.Peek());
        }
    }
}
