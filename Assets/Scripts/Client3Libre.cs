using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Client3Libre : MonoBehaviour
{
    // Start is called before the first frame update
    public int libre = 0;
    public float bout1;
    public float bout2;
    public float bout3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        libre++;
        var bout1recup = other.GetComponent<PasserComande>();
        bout1 = bout1recup.bouteilleType1Voulus;
        bout2 = bout1recup.bouteilleType2Voulus;
        bout3 = bout1recup.bouteilleType3Voulus;
    }

    void OnTriggerExit(Collider other)
    {
        libre--;
        bout1 = 0;
        bout2 = 0;
        bout3 = 0;
    }
}
