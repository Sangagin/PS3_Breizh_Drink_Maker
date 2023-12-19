using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{


    public AudioSource bulles;
    public bool launch=false;
    public BoutonManager boutonManager;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (!launch)
        {
            if (boutonManager.idScene == 1)
            {
                launch = true;
                bulles.Play();
            }
        }
        if(launch)
        {
            if(boutonManager.idScene != 1)
            {
                launch = false;
                bulles.Stop();
            }
        }
    }

}
