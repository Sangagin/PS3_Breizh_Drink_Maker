using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VariableManagerParcelles : MonoBehaviour
{
    // Start is called before the first frame update





    //selection de la grille des parcelles


    public int typePlante;
    public GameObject[] parcelles = new GameObject[] { };

    public int miel;

    public bool action = false;
    private int reccetteActive;



    void Start()
    {
        for(int i = 0; i < parcelles.Length; i++)
        {
            var listeParcelles = parcelles[i].GetComponent<PlanterUnTruc>();
            listeParcelles.id = i;
        }



    }

    // Update is called once per frame
    void Update()
    {



    }

    public int getRecetteActive() { return reccetteActive; }
    public void setRecetteActive(int newRecetteActive) {  reccetteActive = newRecetteActive; }



}
