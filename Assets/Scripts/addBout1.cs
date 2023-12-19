using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addBout1 : MonoBehaviour
{
    // Start is called before the first frame update
    public DonnerCommande donner;
    public int type;
    public UiManager uiManager;
public void addBout()
    {
        if(type == 0)
        {
            if (uiManager.getBouteille1() > 0)
            {
                donner.nbBouteille1++;
                uiManager.setBouteille1(uiManager.getBouteille1() - 1);
            }

        }

        else if(type == 1)
        {
            if (uiManager.getBouteille2() > 0)
            {

                donner.nbBouteille2++;
                uiManager.setBouteille2(uiManager.getBouteille2() - 1);

            }

        }
        else if (type == 2) { }
        {
            if (uiManager.getBouteille2() > 0)
            {  donner.nbBouteille3++;
                uiManager.setBouteille3(uiManager.getBouteille3() - 1);

            }

        }
    }
}
