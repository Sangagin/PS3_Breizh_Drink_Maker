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

            if(variableManager.reccetteActive==1)
            {
                creerBoisson.setMielDonne(0);
                creerBoisson.setPommeDonne(0);
                creerBoisson.setMielBesoin(0);
                creerBoisson.setPommeBesoin(2);
            }
            else if (variableManager.reccetteActive == 2)
            {
                creerBoisson.setMielDonne2(0);
                creerBoisson.setPommeDonne2(0);
                creerBoisson.setMielBesoin2(0);
                creerBoisson.setPommeBesoin2(1);
            }
            else if (variableManager.reccetteActive == 3)
            {
                creerBoisson.setMielDonne2(0);
                creerBoisson.setPommeDonne2(0);
                creerBoisson.setMielBesoin2(1);
                creerBoisson.setPommeBesoin2(2);
            }


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
