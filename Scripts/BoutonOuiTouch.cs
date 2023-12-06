using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoutonOuiTouch : MonoBehaviour, ITouchable
{
    public VariableManagerParcelles variableManagerParcelles;
    public BoutonManager boutonManager;

    public void OnTouchedDown(Vector3 touchPosition)
    {



        for (int i = 0; i < variableManagerParcelles.parcelles.Length; i++)
        {
            var parcelles = variableManagerParcelles.parcelles[i].GetComponent<PlanterUnTruc>();
            if (parcelles.etat == 5)
            {
                parcelles.etat = 1;

            }
        }






    }


    public void OnTouchedStay(Vector3 touchPosition)
    {


    }


    public void OnTouchedUp()
    {

        boutonManager.oui.SetActive(false);
        boutonManager.non.SetActive(false);


    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
