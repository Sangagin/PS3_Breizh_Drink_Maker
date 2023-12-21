using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoutonOuiTouch : MonoBehaviour, ITouchable
{
    public VariableManagerParcelles variableManagerParcelles;
    public BoutonManager boutonManager;

    public GameObject pomme;

    public void OnTouchedDown(Vector3 touchPosition)
    {



        for (int i = 0; i < variableManagerParcelles.parcelles.Length; i++)
        {
            var parcelles = variableManagerParcelles.parcelles[i].GetComponent<PlanterUnTruc>();
            if (parcelles.etat == 5)
            {
              /*  while(parcelles.plantTemp.transform.localScale.x <1f)
                {
                    parcelles.plantTemp.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);

                }
              */
                parcelles.etat = 1;

                pomme.SetActive(false);

               // parcelles.encours = true;
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
