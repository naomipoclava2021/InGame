using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoverPlayer : MonoBehaviour
{
    float velocidad = 1;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
      
    }

    void Mover()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 mov = new Vector3(hor, 0, ver);
        if  (hor !=0 || ver != 0)
        {
            anim.SetFloat("ver", ver);
            anim.SetFloat("hor", hor);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -2f, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 2f, 0);

        }
        transform.Translate(mov * velocidad * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Bailar");
        }
    }
}
