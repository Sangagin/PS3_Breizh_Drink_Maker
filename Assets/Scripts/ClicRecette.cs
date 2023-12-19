using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicRecette : MonoBehaviour, ITouchable
{


    public int id;
    public VariableManagerParcelles variableManager;
    public CreerBoisson1 creerBoisson;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTouchedDown(Vector3 touchPosition) {
        int recetteEnCours = variableManager.getRecetteActive();
        if(id!=recetteEnCours)
        {
            variableManager.setRecetteActive(id);
            creerBoisson.setMielDonne(0);
            creerBoisson.setPommeDonne(0);

        }
    }
    public void OnTouchedStay(Vector3 touchPosition)
    {
        return;
    }
    public void OnTouchedUp()
    {
        return;
    }



}
