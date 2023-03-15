using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject granada;
    public Transform spawnPoint;
    public float rango;
    

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Lanzar();
        }
    }

    void Lanzar()
    {
        GameObject instanciargranada= Instantiate(granada, spawnPoint.position, spawnPoint.rotation);
        instanciargranada.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * rango, ForceMode.Impulse);
    }


}

