using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicHit : MonoBehaviour
{

    public GameObject marqueur;
    public UiManager uiManager;
    public VariableManagerParcelles variableManager;
    public BoutonManager boutonManager;
    public CreerBoisson1 creerBoisson;
    // Start is called before the first frame update
    public void clicBoutonHit()
    {
        Debug.Log(marqueur.transform.position.x);
        int typeCree = variableManager.getRecetteActive();
        if (typeCree == 1)
        {
            uiManager.setBouteille1(uiManager.getBouteille1() + 1);

        }
        else if (typeCree == 2)
        {
            uiManager.setBouteille2(uiManager.getBouteille2() + 1);
        }

        else if (typeCree == 3)
        {
            uiManager.setBouteille3(uiManager.getBouteille3() + 1);
        }

        creerBoisson.setMielDonne(0);
        creerBoisson.setPommeDonne(0);
        boutonManager.setPlein(false);
    }
}
