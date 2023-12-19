using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BougeMarqueur : MonoBehaviour
{

    public GameObject limiteGauche;
    public GameObject limiteDroite;
    public Rigidbody monRb;
    public int sens = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = monRb.velocity;
        vel.x = -3 * sens;
        monRb.velocity = vel;

        if(transform.position.x > limiteDroite.transform.position.x)
        {
            sens = 1;
        }
        else if (transform.position.x < limiteGauche.transform.position.x)
        {
            sens = -1;

        }


    }
}
