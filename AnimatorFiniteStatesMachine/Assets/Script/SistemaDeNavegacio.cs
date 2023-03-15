using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SistemaDeNavegacio : MonoBehaviour
{
    public GameObject objeto2;
    public GameObject objecto3;

    public NavMeshAgent agente;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemigoNavMeshAgente();
    }

    void EnemigoNavMeshAgente()
    {
        agente.SetDestination(transform.position);
    }
}
