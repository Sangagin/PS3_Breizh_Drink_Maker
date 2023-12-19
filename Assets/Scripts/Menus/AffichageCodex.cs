using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffichageCodex : MonoBehaviour
{


    public bool[] listCodexDebloc;
    public GameObject[] listDeblocPhys;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < listCodexDebloc.Length; i++)
        {
            if (listCodexDebloc[i])
            {
                listDeblocPhys[i].SetActive(true);
            }
            else
            {
                listDeblocPhys[i].SetActive (false);
            }
        }
    }
}
