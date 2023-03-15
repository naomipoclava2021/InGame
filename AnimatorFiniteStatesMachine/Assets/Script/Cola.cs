using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cola : MonoBehaviour
{
    Queue persona = new Queue();
    // Start is called before the first frame update
    void Start()
    {
        persona.Enqueue("naomi");
        persona.Enqueue("mauro");
        persona.Enqueue("briza");
        persona.Enqueue(23);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(persona.Dequeue());

        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(persona.Peek());

        }
    }
}
